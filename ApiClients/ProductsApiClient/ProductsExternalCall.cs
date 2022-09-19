using ApiClients.DTOS.Product;
using ApiClients.DTOS.Products;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;
// using static ApiClients.Extensions.Enums;

namespace ApiClients.ProductsApiClient
{
    public class ProductsExternalCall : IProductsExternalCall
    {

        private const string Get_Service_Request_Products = "cds-au/v1/banking/products";
        private const string Get_Request_Params = "?page-size=100";
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProductsExternalCall> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public ProductsExternalCall(HttpClient httpClient, ILogger<ProductsExternalCall> logger, IHttpClientFactory clientFactory)
        {
            _httpClient = httpClient;
            _logger = logger;
            _clientFactory = clientFactory;
        }


        public async Task<ProductsResponseApiAc> GetProductsExternal(string bank)
        {
                
            string path = Get_Service_Request_Products + Get_Request_Params;
            HttpClient httpClient = _clientFactory.CreateClient(bank);
            HttpResponseMessage response = await httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //await SaveChangesAsync();
                return await response.Content.ReadFromJsonAsync<ProductsResponseApiAc>();
            }
            throw new Exception();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="bank"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<ProductResponseApiAc> GetProductExternal(string productId, string bank)
        {
            var path = Get_Service_Request_Products + '/' + productId + Get_Request_Params;
            HttpClient httpClient = _clientFactory.CreateClient(bank);
            HttpResponseMessage response = await httpClient!.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ProductResponseApiAc>();
            }
            throw new Exception();
        }
    }
}
