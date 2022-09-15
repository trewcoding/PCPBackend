using API.DataMappings;
using AutoMapper;
using MediatR;
using System.Reflection;

namespace API.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddAPIService(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.AsScoped();
                
            }, Assembly.GetExecutingAssembly());

            services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }).CreateMapper());

            return services;
        }
    }
}
