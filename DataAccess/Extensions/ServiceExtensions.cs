using DataAccess.Context;
using DataAccess.DataMappings;
using DataAccess.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;


namespace DataAccess.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDataAccessModules(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    SqlOptions => SqlOptions.EnableRetryOnFailure());
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            }, ServiceLifetime.Transient);

            services.AddScoped<IDataAccessLayer, DataAccessLayer>();

            services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }).CreateMapper());
            
            return services;
        }
    }
}
