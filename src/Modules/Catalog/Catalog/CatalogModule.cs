using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace Catalog
{
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Register services related to the Catalog module here
            // For example:
            // services.AddScoped<ICatalogService, CatalogService>();
            return services;

        }

        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Configure the Catalog module middleware here
            return app;
        }
    }
}
