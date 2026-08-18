using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.DocumentTypes.GetDocumentTypes;

namespace Prestamax.Application.Catalogs.DocumentTypes;

/// <summary>
/// Configura las dependencias de los tipos de documentos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddDocumentTypes(
        this IServiceCollection services)
    {
        services.AddScoped<GetDocumentTypesHandler>();

        return services;
    }
}
