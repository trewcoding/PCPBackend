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

        public ProductsPassThrough(IMapper mapper, IDataAccessLayer dataAccessLayer)
        {
            _mapper = mapper;
            _dataAccessLayer = dataAccessLayer;
        }

        public async Task<string> SaveProductsPassThrough(ProductsResponseApi products)
        {
            var dataPassThrough = _mapper.Map<DataEf>(products.Data);
            await _dataAccessLayer.SaveProducts(dataPassThrough);
            return String.Empty;
        }

        public async Task<string> SaveProductPassThrough(ProductData product)
        {
            var dataPassThrough = _mapper.Map<ProductDataEf>(product);
            await _dataAccessLayer.SaveProduct(dataPassThrough);
            return String.Empty;
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
