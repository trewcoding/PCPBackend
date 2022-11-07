using AutoMapper;
using Microsoft.Extensions.Logging;
using DataAccess.Context;
using DataAccess.EfModels.Products;
using DataAccess.EfModels.Product;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<DataAccessLayer> _logger;

        public DataAccessLayer(ApplicationDbContext dbContext, IMapper mapper, ILogger<DataAccessLayer> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<string>> SaveProducts(DataEf products)
        {
            var newOrUpdatedProducts = new List<string>();
            foreach (var item in products.Products)
            {
                var product = await _dbContext.ProductsDataSet.AsNoTracking()
                    .FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                if (product == null)
                {
                    var mappedValue = _mapper.Map<ProductsEf>(item);
                    _dbContext.ProductsDataSet.Add(mappedValue);
                    newOrUpdatedProducts.Add(mappedValue.ProductId);
                }
                else
                {
                    if (product.LastUpdated != item.LastUpdated)
                    {
                        var mappedValue = _mapper.Map<ProductsEf>(item);
                        _dbContext.ProductsDataSet.Update(mappedValue);
                        newOrUpdatedProducts.Add(mappedValue.ProductId);
                    }
                }
                
            }
            await _dbContext.SaveChangesAsync();
            return newOrUpdatedProducts;
        }

        public async Task SaveProduct(ProductDataEf productData)
        {
            var product = await _dbContext.ProductDataSet.AsNoTracking().FirstOrDefaultAsync(x => x.ProductId.Equals(productData.ProductId));
            if (product == null)
            {
                var mappedValue = _mapper.Map<ProductDataEf>(productData);
                _dbContext.ProductDataSet.Add(mappedValue);
                _logger.LogInformation("Added to Database");
            }
            else if (productData.LastUpdated != product.LastUpdated)
            {
                if (product.Fees != null)
                {
                    foreach (var fee in product.Fees)
                    {
                        foreach (var discount in fee.Discounts)
                        {
                            foreach (var eligibility in discount.Eligibility)
                            {
                                await _dbContext.Database.ExecuteSqlRawAsync(
                                    $"DELETE FROM[dbo].[ProductEligibility] WHERE ProductDiscountEfDiscountId='{eligibility.ProductDiscountEfDiscountId}'"
                                    );
                            }
                            await _dbContext.Database.ExecuteSqlRawAsync(
                                    $"DELETE FROM[dbo].[ProductDiscount] WHERE ProductFeeEfProductId='{discount.ProductFeeEfFeeId}'"
                                    );
                        }
                    }
                }
                
                var rowsDeleted = await _dbContext.Database.ExecuteSqlRawAsync(
                    $"DELETE FROM[dbo].[ProductAdditionalInformation] WHERE ProductDataEfProductId='{product.ProductId}'" +
                    $"DELETE FROM[dbo].[ProductConstraint] WHERE ProductDataEfProductId='{product.ProductId}'" +
                    $"DELETE FROM[dbo].[ProductFeatures] WHERE ProductDataEfProductId='{product.ProductId}'" +
                    $"DELETE FROM[dbo].[ProductLendingRates] WHERE ProductDataEfProductId='{product.ProductId}'" +
                    $"DELETE FROM[dbo].[ProductFee] WHERE ProductDataEfProductId='{product.ProductId}'" +
                    $"DELETE FROM[dbo].[ProductEligibility] WHERE ProductDataEfProductId='{product.ProductId}'" +
                    $"DELETE FROM[dbo].[Product] WHERE ProductId='{product.ProductId}'"

                    );
                _logger.LogInformation("Deleted old record from Database");
                var mappedValue = _mapper.Map<ProductDataEf>(productData);
                _dbContext.ProductDataSet.Add(mappedValue);
                _logger.LogInformation("Updated Database");
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ProductDataEf> GetProductDetails(string productId)
        {
            return await _dbContext.ProductDataSet
                .Include(p => p.Features)
                .Include(p => p.Constraints)
                .Include(p => p.Eligibility)
                .Include(p => p.LendingRates)
                .Include(p => p.AdditionalInformation)
                .Include(p => p.Fees)
                .ThenInclude(y => y.Discounts)
                .ThenInclude(x => x.Eligibility)
                .FirstOrDefaultAsync(x => x.ProductId.Equals(productId));
        }

        public async Task<List<ProductsEf>> GetAllProducts()
        {
            return await _dbContext.ProductsDataSet.ToListAsync();
            
        }
    }
}
