using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Configuration.Modules;

namespace Prestamax.Infrastructure.Configuration.Modules;

/// <summary>
/// Configura las dependencias de los módulos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddModules(
        this IServiceCollection services)
    {
        services.AddScoped<
            IModuleRepository,
            ModuleRepository>();

        services.AddScoped<
            IModuleActionRepository,
            ModuleActionRepository>();

        return services;
    }
}