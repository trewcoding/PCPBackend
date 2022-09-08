using AutoMapper;
using DataAccess.Context;
using DataAccess.DTOS.ProductCommBank;
using DataAccess.EfModels.ProductCommBank;
using DataAccess.EfModels.ProductsCommBank;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public DataAccessLayer(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> SaveProducts(List<Products> products)
        {
            foreach (var item in products)
            {
                var product = await  _dbContext.ProductsDataSet.AsNoTracking().FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                
                if (product == null)
                {
                    var mappedValue = _mapper.Map<ProductsEF>(item);
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
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
        }

        public async Task<ProductDataDto> GetProductDetails(string productId)
        {
            var product = await _dbContext.ProductDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(productId));
            return _mapper.Map<ProductDataDto>(product);  
        }

    }
}
