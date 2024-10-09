using Application;
using Application.Facade;
using Domain.Repositories;
using Repository.Facade;
using Storage;
using Storage.Facade;

namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IFunctionsManager, FunctionsManager>();
            services.AddScoped<ICustomerContext, CustomerContext>();
        }
    }
}
