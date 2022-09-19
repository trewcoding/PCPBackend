using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DataAccess.Context;
using DataAccess.EfModels.Products;
using DataAccess.EfModels.Product;

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
        public async Task<string> SaveProducts(DataEf products)
        {
            foreach (var item in products.Products)
            {
                var product = await _dbContext.ProductsDataSet.AsNoTracking()
                                                              .FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                if (product == null)
                {

                    var mappedValue = _mapper.Map<ProductsEf>(item);
                    _dbContext.ProductsDataSet.Add(mappedValue);
                }
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
        }

        public async Task<string> SaveProduct(ProductDataEf productData)
        {
            var product = await _dbContext.ProductDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(productData.ProductId));
            if (product == null)
            {
                var mappedValue = _mapper.Map<ProductDataEf>(productData);
                _dbContext.ProductDataSet.Add(mappedValue);
                _logger.LogInformation("Added to Database");
            }
            else if (productData.LastUpdated != product.LastUpdated)
            {
                var mappedValue = _mapper.Map<ProductDataEf>(productData);
                _logger.LogInformation("Updated Database");
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
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
