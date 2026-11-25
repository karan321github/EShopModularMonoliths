using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services
            , IConfiguration configuration
            )
        {
            // Register services related to the Ordering module here
            // For example:
            // services.AddScoped<IOrderingService, OrderingService>();
            return services;
        }
        
        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            // Configure middleware related to the Ordering module here
            // For example:
            // app.UseMiddleware<OrderingMiddleware>();
            return app;
        }   
    }
}
