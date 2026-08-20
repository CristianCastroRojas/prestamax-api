using Microsoft.Extensions.DependencyInjection;
using Prestamax.Infrastructure.Catalogs.DocumentTypes;
using Prestamax.Infrastructure.Catalogs.UserStatuses;

namespace Prestamax.Infrastructure.Catalogs;

/// <summary>
/// Configura las dependencias de los catálogos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddCatalogInfrastructure(
        this IServiceCollection services)
    {
        services.AddDocumentTypes();

        services.AddUserStatuses();

        return services;
    }
}