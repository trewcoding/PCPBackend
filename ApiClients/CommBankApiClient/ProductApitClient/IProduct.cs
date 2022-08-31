using Domain.Entities.ProductCommBank;

namespace ApiClients.CommBankApiClient.ProductApitClient
{
    public interface IProduct
    {
        Task<ProductResponseApi> GetProduct(string productId);
    }
}
