using Data;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Utility
{
    public static class EntityFrameworkExtension
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, string connectionString )
        {
            services.AddDbContext<MyContext>(options =>
                options.UseNpgsql(connectionString, x => x.MigrationsAssembly("WebApp")));

            //services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPersonRepository, PersonRepository>();

            return services;
        }
        
    }
}