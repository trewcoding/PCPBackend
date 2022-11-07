using Microsoft.Extensions.DependencyInjection;
using ApiClients.ProductsApiClient;
using static ApiClients.Extensions.Enums;

namespace ApiClients.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApiClientsMapping(this IServiceCollection services) 
        {
            services.AddScoped<IProductsExternalCall, ProductsExternalCall>();
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.commBank}", commBank =>
            {
                commBank.BaseAddress = new Uri("https://api.commbank.com.au/public/");
                commBank.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.nab}", nab =>
            {
                nab.BaseAddress = new Uri("https://openbank.api.nab.com.au/");
                nab.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.westpac}", westpac =>
            {
                westpac.BaseAddress = new Uri("https://digital-api.westpac.com.au/");
                westpac.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.anz}", anz =>
            {
                anz.BaseAddress = new Uri("https://api.anz/");
                anz.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.bendigoBank}", bendigoBank =>
            {
                bendigoBank.BaseAddress = new Uri("https://api.cdr.bendigobank.com.au/");
                bendigoBank.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.macquarie}", macquarie =>
            {
                macquarie.BaseAddress = new Uri("https://api.macquariebank.io/");
                macquarie.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.adelaide}", adelaide =>
            {
                adelaide.BaseAddress = new Uri("https://api.cdr.adelaidebank.com.au/");
                adelaide.DefaultRequestHeaders.Add("x-v", "3");
            });
            services.AddHttpClient<IProductsExternalCall, ProductsExternalCall>($"{Banks.boq}", boq =>
            {
                boq.BaseAddress = new Uri("https://secure.api.boq.com.au/");
                boq.DefaultRequestHeaders.Add("x-v", "3");
            });


            return services;
        }
    }
}

//Lambda expressions and delegates, Polly extension
