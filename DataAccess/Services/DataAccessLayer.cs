using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DataAccess.Context;
using DataAccess.EfModels.Products;
using DataAccess.EfModels.Product;
using Domain.Entities.Product;
using Domain.Entities.Products;

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
        public async Task<string> SaveProducts(Data data)
        {
            foreach (var item in data.Products)
            {
                var product = await  _dbContext.ProductsDataSet.AsNoTracking().FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                if (product == null)
                {

                    var mappedValue = _mapper.Map<ProductsEf>(item);
                    _dbContext.ProductsDataSet.Add(mappedValue);
                }
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
        }

        public async Task<string> SaveProduct(ProductData productData)
        {
            var product = await _dbContext.ProductDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(productData.ProductId));
            if (product == null)
            {
                var mappedValue = _mapper.Map<ProductDataEf>(productData);
                _dbContext.ProductDataSet.Add(mappedValue);
                _logger.LogInformation("Added to Database");
            }
            else if(productData.LastUpdated != product.LastUpdated)
            {
                var mappedValue = _mapper.Map<ProductDataEf>(productData);
                _logger.LogInformation("Updated Database");
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
        }

        public async Task<ProductData> GetProductDetails(string productId)
        {
            var product = await _dbContext.ProductDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(productId));
            return _mapper.Map<ProductData>(product);
        }

    }
}
