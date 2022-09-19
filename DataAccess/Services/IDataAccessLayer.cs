using DataAccess.EfModels.Product;
using DataAccess.EfModels.Products;

namespace DataAccess.Services
{
    public interface IDataAccessLayer
    {
        Task<string> SaveProducts(DataEf product);
        Task<string> SaveProduct(ProductDataEf productData);
        Task<ProductDataEf> GetProductDetails(string productId);
        Task<List<ProductsEf>> GetAllProducts();
    }
}
