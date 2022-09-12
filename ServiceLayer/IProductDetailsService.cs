using ApiClients.DTOS.ProductsCommBank;
using Domain.Entities.ProductsCommBank;
using ServiceLayer.DTOS.ProductCommBank;

namespace ServiceLayer
{
    public interface IProductsServices
    {
        Task<ProductResponseApiSL> GetProductAsync(string productId, string bank);
    }
}
