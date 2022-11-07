using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.DataMappings;
using ServiceLayer.DetailsService;

namespace ServiceLayer.Extemsions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServiceLayerModules(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductServices>();
            //services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile<AutoMapperProfile>();
            //}).CreateMapper());
            services.AddAutoMapper(typeof(AutoMapperSl).Assembly);
            return services;
        }
    }
}
