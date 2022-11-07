using AutoMapper;
using Domain.Entities.Products;
using DataAccess.Services;
using DataAccess.EfModels.Products;
using DataAccess.EfModels.Product;
using Domain.Entities.Product;

namespace Domain.Services
{
    public class ProductsPassThrough : IProductsPassThrough
    {

        private readonly IMapper _mapper;
        private readonly IDataAccessLayer _dataAccessLayer;
        private readonly IStringProcessing _stringProcessing;

        public ProductsPassThrough(IMapper mapper, IDataAccessLayer dataAccessLayer, IStringProcessing stringProcessing)
        {
            _mapper = mapper;
            _dataAccessLayer = dataAccessLayer;
            _stringProcessing = stringProcessing;
        }

        public async Task<List<string>> SaveProductsPassThrough(ProductsResponseApi products)
        {
            var dataStringParsing = await _stringProcessing.StringReplaceProducts(products);
            var dataPassThrough = _mapper.Map<DataEf>(dataStringParsing.Data);
            var newOrUpdatedProducts = await _dataAccessLayer.SaveProducts(dataPassThrough);
            return newOrUpdatedProducts;
        }

        public async Task SaveProductPassThrough(ProductData product)
        {
            var dataStringParsing = await _stringProcessing.StringReplaceProduct(product);
            var dataPassThrough = _mapper.Map<ProductDataEf>(dataStringParsing);
            await _dataAccessLayer.SaveProduct(dataPassThrough);
        }

        public async Task<ProductData> GetProductDetailsPassThrough(string productId)
        {
            var result = await _dataAccessLayer.GetProductDetails(productId);
            var mappedResult = _mapper.Map<ProductData>(result);
            return mappedResult;
        }

        public async Task<List<Products>> GetAllProductsPassThrough()
        {
            var result = await _dataAccessLayer.GetAllProducts();
            var mappedResult = _mapper.Map<List<Products>>(result);
            return mappedResult;
        }
    }
}
