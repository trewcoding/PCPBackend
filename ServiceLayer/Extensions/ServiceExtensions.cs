using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceLayer.Extemsions
{
    public static class ServiceExtensions
    {
        public static void AddServiceLayerModules(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IProductDetailsGetter, ProductDetailsGetter>();
        }
    }
}
