using ApiClients.CommBankApiClient.ProductsApiClient;
using DataAccess.Context;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Products = Domain.Entities.ProductsCommBank.Products;

namespace ApiClients.CommBankApiClient.ProductApitClient
{
    public class Product : IProduct
    {
        private const string Get_Service_Request_Product = "public/cds-au/v1/banking/products/";
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProductsApiClient.Products> _logger;
        private readonly ApplicationDbContext _dbContext;

        public Product(HttpClient httpClient, ILogger<ProductsApiClient.Products> logger, ApplicationDbContext dbContext)
        {
            _httpClient = httpClient;
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<ProductResponseApi> GetProduct(string productId)
        {
            var path = Get_Service_Request_Product + productId;
            var response = await _httpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //await SaveChangesAsync();
                return await response.Content.ReadFromJsonAsync<ProductResponseApi>();
            }
            throw new Exception();
        }
    }
}
