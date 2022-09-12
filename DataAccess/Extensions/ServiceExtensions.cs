using DataAccess.Context;
using DataAccess.Services;
using Domain.ProductMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDataAccessModules(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    SqlOptions => SqlOptions.EnableRetryOnFailure());
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            }, ServiceLifetime.Transient);

            services.AddScoped<IDataAccessLayer, DataAccessLayer>();

            services.AddAutoMapper(typeof(ProductMappings).Assembly);


        }
    }
}
