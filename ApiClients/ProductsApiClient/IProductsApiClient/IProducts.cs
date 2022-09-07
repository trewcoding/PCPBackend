using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;

namespace ApiClients.ProductsApiClient.IProductsApiClient
{
    public interface IProducts
    {
        Task<ProductsResponseApi> GetProducts(string bank);
        Task<ProductResponseApi> GetProduct(string productId, string bank);
    }
}
