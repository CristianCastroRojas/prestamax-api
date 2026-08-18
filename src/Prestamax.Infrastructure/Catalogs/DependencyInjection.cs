using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.DocumentTypes;
using Prestamax.Infrastructure.Catalogs.DocumentTypes;

namespace Prestamax.Infrastructure.Catalogs;

/// <summary>
/// Configura las dependencias de los catálogos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddCatalogs(
        this IServiceCollection services)
    {
        services.AddScoped<
            IDocumentTypeRepository,
            DocumentTypeRepository>();

        return services;
    }
}