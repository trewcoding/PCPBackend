using AutoMapper;
using DataAccess.Services;
using ApiClients.ProductsApiClient;
using ServiceLayer.DTOS.ProductsCommBank;
using ServiceLayer.DTOS.ProductCommBank;

namespace ServiceLayer
{
    public class ProductsServices : IProductsServices
    {
        private readonly IMapper _mapper;
        private readonly IProducts _product;
        private readonly IDataAccessLayer _dataAccessLayer;

        public ProductsServices(IMapper mapper, IProducts product, IDataAccessLayer dataAccessLayer)
        {
            _mapper = mapper;
            _product = product;
            _dataAccessLayer = dataAccessLayer;
        }
        public async Task<ProductResponseApiSL> GetProductAsync(string productId, string bank)
        {
            var result = await _product.GetProduct(productId, bank);
            await _dataAccessLayer.SaveProduct(result.Data);
            var mappedResult = _mapper.Map<ProductResponseApiSL>(result);
            return mappedResult;
        }

        //public async Task<string> GetProductsAsync()
    }
}
