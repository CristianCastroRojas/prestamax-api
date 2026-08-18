using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Configuration.Modules;
using Prestamax.Application.Configuration.SystemVersions;

namespace Prestamax.Application.Configuration;

/// <summary>
/// Configura las dependencias de configuración.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddConfiguration(
        this IServiceCollection services)
    {
        services.AddSystemVersions();

        services.AddModules();

        return services;
    }
}