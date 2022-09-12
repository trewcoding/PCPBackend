using API.Handlers;
using MediatR;

namespace API.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void AddApiModules(this IServiceCollection services)
        {
            //services.AddScoped<IDataAccessLayer, DataAccessLayer>();
            //services.AddScoped<IMediator, Mediator>();
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(typeof(HandlerProductDetails).Assembly);
            //services.AddMediatR(typeof(QueryListAllProducts).Assembly);
        }
    }
}
