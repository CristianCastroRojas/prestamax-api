using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prestamax.Infrastructure.Catalogs;
using Prestamax.Infrastructure.Configuration;
using Prestamax.Infrastructure.Persistence;
using Prestamax.Infrastructure.Tenant;

namespace Prestamax.Infrastructure;

/// <summary>
/// Configura las dependencias de infraestructura.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDatabase(configuration);

        services.AddCatalogInfrastructure();

        services.AddConfigurationInfrastructure();

        services.AddTenantInfrastructure();

        return services;
    }
}