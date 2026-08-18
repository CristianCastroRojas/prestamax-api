using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs;
using Prestamax.Application.Configuration;
using Prestamax.Application.Organizations;

namespace Prestamax.Application;

/// <summary>
/// Configura las dependencias de la aplicación.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddCatalogs();

        services.AddOrganizations();

        services.AddConfiguration();

        return services;
    }
}