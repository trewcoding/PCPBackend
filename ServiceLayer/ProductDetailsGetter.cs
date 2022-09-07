using ApiClients.ProductsApiClient.IProductsApiClient;
using AutoMapper;
using DataAccess.Context;
using DataAccess.Services;
using Domain.Entities.ProductsCommBank;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{
    public class ProductDetailsGetter : IProductDetailsGetter
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IProducts _product;
        private readonly IDataAccessLayer _dataAccessLayer;

        public ProductDetailsGetter(ApplicationDbContext dbContext, IMapper mapper, IProducts product, IDataAccessLayer dataAccessLayer)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _product = product;
            _dataAccessLayer = dataAccessLayer;
        }
        public async Task<string> GetProductDetailsAsync(List<Products> products, string bank)
        {
            foreach (var item in products)
            {
                var product = await _dbContext.ProductDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                if (product == null)
                {

                    var result = await _product.GetProduct(item.ProductId, bank);
                    await _dataAccessLayer.SaveProduct(result.Data);
                }
                else
                {
                    if (product.LastUpdated != item.LastUpdated)
                    {

                        var result = await _product.GetProduct(item.ProductId, bank);
                        await _dataAccessLayer.SaveProduct(result.Data);
                    }
                }
            }
            return String.Empty;
        }
    }
}
