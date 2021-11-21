using Microsoft.Extensions.DependencyInjection;

namespace ImdbClient
{
    public static class DependencyInjection
    {
        public static void ConfigureImdbClient(this IServiceCollection services, string baseUrl, string apiKey, string language = "en")
        {
            services.AddScoped<IImdbClient>(provider => new ImdbClient(baseUrl, apiKey, language));
        }
    }
}
