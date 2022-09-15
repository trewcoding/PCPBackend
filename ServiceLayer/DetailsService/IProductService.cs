using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;

namespace ServiceLayer.DetailsService
{
    public interface IProductService
    {
        Task<ProductResponseApiSl> GetProductAsync(string productId, string bank);
        Task<ProductsResponseApiSl> GetProductsExternalCall(string bank);
    }
}
