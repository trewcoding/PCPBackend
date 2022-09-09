using DataAccess.Activities;
using DataAccess.Services;
using MediatR;
using System.Reflection;

namespace API.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void AddApiModules(this IServiceCollection services)
        {
            services.AddScoped<IDataAccessLayer, DataAccessLayer>();
            services.AddScoped<IMediator, Mediator>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(typeof(HandlerProductDetails).Assembly);
        }
    }
}
