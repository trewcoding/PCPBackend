using ApiClients.DTOS.Product;
using ApiClients.DTOS.Products;

namespace ApiClients.ProductsApiClient
{
    public interface IProductsExternalCall
    {
        Task<ProductsResponseApiAc> GetProductsExternal(string bank);
        Task<ProductResponseApiAc> GetProductExternal(string productId, string bank);
    }
}
