using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.DocumentTypes;
using Prestamax.Application.Catalogs.UserStatuses;

namespace Prestamax.Application.Catalogs;

/// <summary>
/// Configura las dependencias de los catálogos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddCatalogs(
        this IServiceCollection services)
    {
        services.AddDocumentTypes();

        services.AddUserStatuses();

        return services;
    }
}