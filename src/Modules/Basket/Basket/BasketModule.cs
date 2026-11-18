using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Register services related to the Basket module here
            // For example:
            // services.AddScoped<IBasketService, BasketService>();
            return services;
        }
    }
}