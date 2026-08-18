using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs;

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

        return services;
    }
}