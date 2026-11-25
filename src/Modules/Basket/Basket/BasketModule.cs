using Microsoft.AspNetCore.Builder;
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

        public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
        {
            // Configure middleware related to the Basket module here
            // For example:
            // app.UseMiddleware<BasketMiddleware>();
            return app;
        }
    }
}