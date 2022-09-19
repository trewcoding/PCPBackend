using AutoMapper;
using ApiClients.ProductsApiClient;
using ServiceLayer.DTOS.Products;
using ServiceLayer.DTOS.Product;
using Domain.Entities.Products;
using Domain.Services;
using Domain.Entities.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.DetailsService
{
    public class ProductServices : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductsExternalCall _productsExternalCall;
        private readonly IProductsPassThrough _productsPassThrough;
        

        public ProductServices(IMapper mapper, IProductsExternalCall productsExternalCall, IProductsPassThrough productsPassThrough)
        {
            _mapper = mapper;
            _productsExternalCall = productsExternalCall;
            _productsPassThrough = productsPassThrough;
        }
        /// <summary>
        /// Gets the information for each of the products from each of the banks and saves it to the db
        /// </summary>
        /// <param name="productId">The given id of a product</param>
        /// <param name="bank">The bank the product corresponds to</param>
        /// <returns>detailed product information</returns>
        public async Task<ProductResponseApiSl> SaveProductAsync(string productId, string bank)
        {
            var result = await _productsExternalCall.GetProductExternal(productId, bank);
            var mappedResultSl = _mapper.Map<ProductResponseApiSl>(result);
            var mappedResult = _mapper.Map<ProductResponseApi>(mappedResultSl);
            await _productsPassThrough.SaveProductPassThrough(mappedResult.Data);
            return mappedResultSl;
        }
        /// <summary>
        /// Get Products from the external api call and save the data to the db
        /// </summary>
        /// <param name="bank">Enum list of all the different banks</param>
        /// <returns>Response from the api call</returns>
        public async Task<ProductsResponseApiSl> SaveProductsExternalCall(string bank)
        {
            var result = await _productsExternalCall.GetProductsExternal(bank);
            var mappedResultSl = _mapper.Map<ProductsResponseApiSl>(result);
            var mappedResult = _mapper.Map<ProductsResponseApi>(mappedResultSl);
            await _productsPassThrough.SaveProductsPassThrough(mappedResult);

            return mappedResultSl;
        }
        public async Task<ProductDataSl> GetProductDetails(string productId)
        {
            var result = await _productsPassThrough.GetProductDetailsPassThrough(productId);
            var mappedResult = _mapper.Map<ProductDataSl>(result);
            return mappedResult;
        }
        public async Task<List<ProductsSl>> GetAllProducts()
        {
            var products = await _productsPassThrough.GetAllProductsPassThrough();
            var mappedResult = _mapper.Map<List<ProductsSl>>(products);
            return mappedResult;
        }
    }
}
