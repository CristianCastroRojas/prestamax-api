using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prestamax.Infrastructure.Catalogs;
using Prestamax.Infrastructure.Configuration;
using Prestamax.Infrastructure.Organizations;
using Prestamax.Infrastructure.Persistence;

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

        services.AddCatalogs();

        services.AddConfiguration();

        services.AddOrganizations();

        return services;
    }
}