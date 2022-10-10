using AutoMapper;
using Domain.DataMappings;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDomainModules(this IServiceCollection services)
        {
            services.AddScoped<IProductsPassThrough, ProductsPassThrough>();
            services.AddScoped<IStringProcessing, StringProcessing>();
            services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }).CreateMapper());
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}

