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
        private readonly ILogger<Products> _logger;
        private readonly IHttpClientFactory _clientFactory;


        public Products(ILogger<Products> logger, IHttpClientFactory clientFactory)
        { 
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="bank"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<ProductResponseApi> GetProduct(string productId, string bank)
        {
            var path = Get_Service_Request_Products + '/' + productId;
            HttpClient httpClient = _clientFactory.CreateClient(bank);
            HttpResponseMessage response = await httpClient!.GetAsync(path) ;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ProductResponseApi>();
            }
            throw new Exception();
        }
        
        





    }
}
