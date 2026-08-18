using Microsoft.Extensions.DependencyInjection;
using Prestamax.Infrastructure.Configuration.Modules;
using Prestamax.Infrastructure.Configuration.Settings;
using Prestamax.Infrastructure.Configuration.SystemVersions;

namespace Prestamax.Infrastructure.Configuration;

/// <summary>
/// Configura las dependencias de configuración.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddConfiguration(
        this IServiceCollection services)
    {
        services.AddSystemVersions();

        services.AddSettings();

        services.AddModules();

        return services;
    }
}