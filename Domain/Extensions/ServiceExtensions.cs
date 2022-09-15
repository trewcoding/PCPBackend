using AutoMapper;
using Domain.DataMappings;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDomainModules(this IServiceCollection services)
        {

            services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }).CreateMapper());

            return services;
        }
    }
}

