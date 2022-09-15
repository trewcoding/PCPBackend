using ApiClients.DTOS.Product;
using ApiClients.DTOS.Products;

namespace ApiClients.ProductsApiClient
{
    public interface IProductsExternalCall
    {
        Task<ProductsResponseApiAc> GetProducts(string bank);
        Task<ProductResponseApiAc> GetProduct(string productId, string bank);
    }
}
