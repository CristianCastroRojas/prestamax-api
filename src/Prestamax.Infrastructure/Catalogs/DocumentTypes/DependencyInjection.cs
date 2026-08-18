using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.DocumentTypes;

namespace Prestamax.Infrastructure.Catalogs.DocumentTypes;

/// <summary>
/// Configura las dependencias de los tipos de documentos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddDocumentTypes(
        this IServiceCollection services)
    {
        services.AddScoped<
            IDocumentTypeRepository,
            DocumentTypeRepository>();

        return services;
    }
}
