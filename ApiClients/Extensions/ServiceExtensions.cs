using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ApiClients.CommBankApiClient.ProductsApiClient.IProductsApiClient;
using ApiClients.CommBankApiClient.ProductsApiClient;
using ApiClients.CommBankApiClient.ProductApitClient;

namespace ApiClients.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApiClientsMapping(this IServiceCollection services) 
        {

            services.AddHttpClient<IProducts, Products>(client =>
            {
                client.BaseAddress = new Uri("https://api.commbank.com.au/");
                client.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProduct, Product>(client =>
            {
                client.BaseAddress = new Uri("https://api.commbank.com.au/");
                client.DefaultRequestHeaders.Add("x-v", "3");
            });
        }
    }
}

//Lambda expressions and delegates, Polly extension
