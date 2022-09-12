using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.DataMappings;

namespace ServiceLayer.Extemsions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServiceLayerModules(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductsServices, ProductsServices>();
            services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }).CreateMapper());
            return services;
        }
    }
}
