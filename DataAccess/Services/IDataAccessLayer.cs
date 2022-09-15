using Domain.Entities.Product;
using Domain.Entities.Products;

namespace DataAccess.Services
{
    public interface IDataAccessLayer
    {
        Task<string> SaveProducts(List<Products> product);
        Task<string> SaveProduct(ProductData productData);
        Task<ProductData> GetProductDetails(string productId);
    }
}
