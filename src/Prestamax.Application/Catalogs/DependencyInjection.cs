using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.DocumentTypes.GetDocumentTypes;

namespace Prestamax.Application.Catalogs;

/// <summary>
/// Configura las dependencias de los catálogos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddCatalogs(
        this IServiceCollection services)
    {
        services.AddScoped<GetDocumentTypesHandler>();

        return services;
    }
}