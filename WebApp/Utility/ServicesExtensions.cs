using Microsoft.Extensions.DependencyInjection;
using WebApp.Services;

namespace WebApp.Utility
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddLocalServices(this IServiceCollection services)
        {
            services.AddTransient<IMainService, MainService>();
            return services;
        }
    }
}