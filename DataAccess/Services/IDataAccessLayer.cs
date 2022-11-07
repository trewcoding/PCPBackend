using DataAccess.EfModels.Product;
using DataAccess.EfModels.Products;

namespace DataAccess.Services
{
    public interface IDataAccessLayer
    {
        Task<List<string>> SaveProducts(DataEf product);
        Task SaveProduct(ProductDataEf productData);
        Task<ProductDataEf> GetProductDetails(string productId);
        Task<List<ProductsEf>> GetAllProducts();
    }
}
