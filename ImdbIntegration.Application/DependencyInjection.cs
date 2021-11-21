using ImdbClient;
using ImdbIntegration.Application.Services;
using ImdbIntegration.Domain.Interfaces;
using ImdbIntegration.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImdbIntegration.Application
{
    public static class DependencyInjection
    {
        public static void ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureImdbClient(configuration.GetValue<string>("ImDb:baseUrl"), configuration.GetValue<string>("ImDb:apiKey"), configuration.GetValue<string>("ImDb:language"));

            services.AddDbContext<ImdbContext>
              (options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                                                    b => b.MigrationsAssembly("ImdbIntegration.Infrastructure")));

            services.AddScoped<IImdbContext, ImdbContext>();
            services.AddScoped<IWatchListService, WatchListService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
