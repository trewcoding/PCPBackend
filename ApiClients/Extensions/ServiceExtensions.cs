using Microsoft.Extensions.DependencyInjection;
using ApiClients.ProductsApiClient.IProductsApiClient;
using ApiClients.ProductsApiClient;
using static ApiClients.Extensions.Enums;

namespace ApiClients.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApiClientsMapping(this IServiceCollection services) 
        {
            services.AddHttpClient<IProducts, Products>($"{Banks.commBank}", commBank =>
            {
                commBank.BaseAddress = new Uri("https://api.commbank.com.au/public/");
                commBank.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProducts, Products>($"{Banks.nab}", nab =>
            {
                nab.BaseAddress = new Uri("https://openbank.api.nab.com.au/");
                nab.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProducts, Products>($"{Banks.westpac}", westpac =>
            {
                westpac.BaseAddress = new Uri("https://digital-api.westpac.com.au/");
                westpac.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProducts, Products>($"{Banks.anz}", anz =>
            {
                anz.BaseAddress = new Uri("https://api.anz/");
                anz.DefaultRequestHeaders.Add("x-v", "3");
            });
            return services;
        }
    }
}

//Lambda expressions and delegates, Polly extension
