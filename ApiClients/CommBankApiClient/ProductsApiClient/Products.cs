using ApiClients.CommBankApiClient.ProductsApiClient.IProductsApiClient;
using Domain.Entities.ProductsCommBank;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace ApiClients.CommBankApiClient.ProductsApiClient
{
    public class Products : IProducts
    {
        
        private const string Get_Service_Request_Products = "public/cds-au/v1/banking/products";
        private readonly HttpClient _httpClient;
        private readonly ILogger<Products> _logger;   

        public Products(HttpClient httpClient, ILogger<Products> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<ProductsResponseApi> GetProducts()
        {
            string path = Get_Service_Request_Products;
            var response = await _httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //await SaveChangesAsync();
                return await response.Content.ReadFromJsonAsync<ProductsResponseApi>();
            }
            throw new Exception();
        }



        

    }
}
