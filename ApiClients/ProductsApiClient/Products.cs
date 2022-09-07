using ApiClients.ProductsApiClient.IProductsApiClient;
using DataAccess.Context;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;
using static ApiClients.Extensions.Enums;

namespace ApiClients.ProductsApiClient
{
    public class Products : IProducts
    {

        private const string Get_Service_Request_Products = "cds-au/v1/banking/products";
        private readonly HttpClient _httpClient;
        private readonly ILogger<Products> _logger;
        private readonly IHttpClientFactory _clientFactory;


        public Products(HttpClient httpClient, ILogger<Products> logger, IHttpClientFactory clientFactory)
        {
            _httpClient = httpClient;
            _logger = logger;
            _clientFactory = clientFactory;
        }


        public async Task<ProductsResponseApi> GetProducts(string bank)
        {
            
            string path = Get_Service_Request_Products;
            var httpClient = _clientFactory.CreateClient(bank);//$"{Banks.commBank}");
            var response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //await SaveChangesAsync();
                return await response.Content.ReadFromJsonAsync<ProductsResponseApi>();
            }
            throw new Exception();
            
        }

        public async Task<ProductResponseApi> GetProduct(string productId, string bank)
        {
            var path = Get_Service_Request_Products + '/' + productId;
            var httpClient = _clientFactory.CreateClient(bank);
            var response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ProductResponseApi>();
            }
            throw new Exception();
        }
        
        





    }
}
