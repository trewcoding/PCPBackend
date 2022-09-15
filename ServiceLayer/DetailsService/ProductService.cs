using AutoMapper;
using DataAccess.Services;
using ApiClients.ProductsApiClient;
using ServiceLayer.DTOS.Products;
using ServiceLayer.DTOS.Product;

namespace ServiceLayer.DetailsService
{
    public class ProductServices : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductsExternalCall _productsExternalCall;
        private readonly IDataAccessLayer _dataAccessLayer;

        public ProductServices(IMapper mapper, IProductsExternalCall productsExternalCall, IDataAccessLayer dataAccessLayer)
        {
            _mapper = mapper;
            _productsExternalCall = productsExternalCall;
            _dataAccessLayer = dataAccessLayer;
        }
        public async Task<ProductResponseApiSl> GetProductAsync(string productId, string bank)
        {
            var result = await _productsExternalCall.GetProduct(productId, bank);
            var mappedResult = _mapper.Map<ProductResponseApiSl>(result);
            //await _dataAccessLayer.SaveProduct(mappedResult.Data);
            return mappedResult;
        }
        public async Task<ProductsResponseApiSl> GetProductsExternalCall(string bank)
        {
            var result = await _productsExternalCall.GetProducts(bank);
            var mappedResult = _mapper.Map<ProductsResponseApiSl>(result);
            return mappedResult;
        }

    }
}
