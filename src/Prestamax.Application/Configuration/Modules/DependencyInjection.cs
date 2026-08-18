using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Configuration.Modules.GetModules;

namespace Prestamax.Application.Configuration.Modules;

/// <summary>
/// Configura las dependencias de los módulos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddModules(
        this IServiceCollection services)
    {
        services.AddScoped<GetModulesHandler>();

        return services;
    }
}