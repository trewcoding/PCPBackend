using AutoMapper;
using DataAccess.Services;
using ApiClients.ProductsApiClient;
using ServiceLayer.DTOS.Products;
using ServiceLayer.DTOS.Product;
using Domain.Entities.Products;

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
        /// <summary>
        /// Gets the information for each of the products from each of the banks and saves it to the db
        /// </summary>
        /// <param name="productId">The given id of a product</param>
        /// <param name="bank">The bank the product corresponds to</param>
        /// <returns>detailed product information</returns>
        public async Task<ProductResponseApiSl> GetProductAsync(string productId, string bank)
        {
            var result = await _productsExternalCall.GetProduct(productId, bank);
            var mappedResult = _mapper.Map<ProductResponseApiSl>(result);
            //await _dataAccessLayer.SaveProduct(mappedResult.Data);
            return mappedResult;
        }
        /// <summary>
        /// Get Products from the external api call and save the data to the db
        /// </summary>
        /// <param name="bank">Enum list of all the different banks</param>
        /// <returns>Response from the api call</returns>
        public async Task<ProductsResponseApiSl> GetProductsExternalCall(string bank)
        {
            var result = await _productsExternalCall.GetProducts(bank);
            var mappedResultSl = _mapper.Map<ProductsResponseApiSl>(result);
            var mappedResult = _mapper.Map<Data>(mappedResultSl.Data);
            await _dataAccessLayer.SaveProducts(mappedResult);

            return mappedResultSl;
        }

    }
}
