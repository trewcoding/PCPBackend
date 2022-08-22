using DataAccess.Context;
using DataAccess.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDataAccessModules(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionStrings:DefaultConnection"),
                    SqlOptions => SqlOptions.EnableRetryOnFailure());
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            },ServiceLifetime.Transient);

            services.AddScoped<IDataAccessLayer, DataAccessLayer>();
        }
    }
}
