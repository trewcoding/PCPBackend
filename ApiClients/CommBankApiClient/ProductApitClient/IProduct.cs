using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;

namespace ApiClients.CommBankApiClient.ProductApitClient
{
    public interface IProduct
    {
        Task<ProductResponseApi> GetProduct(string productId);
    }
}
