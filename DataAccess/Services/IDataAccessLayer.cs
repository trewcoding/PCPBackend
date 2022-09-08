using DataAccess.DTOS.ProductCommBank;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;

namespace DataAccess.Services
{
    public interface IDataAccessLayer
    {
        Task<string> SaveProducts(List<Products> product);
        Task<string> SaveProduct(ProductData productData);
        Task<ProductDataDto> GetProductDetails(string productId);
    }
}
