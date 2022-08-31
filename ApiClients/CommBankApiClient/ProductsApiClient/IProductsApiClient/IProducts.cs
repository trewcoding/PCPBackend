using Domain.Entities.ProductsCommBank;

namespace ApiClients.CommBankApiClient.ProductsApiClient.IProductsApiClient
{
    public interface IProducts
    {
        Task<ProductsResponseApi> GetProducts();
    }
}
