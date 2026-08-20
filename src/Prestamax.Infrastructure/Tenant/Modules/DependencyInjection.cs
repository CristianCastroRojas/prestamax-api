using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.Modules;

namespace Prestamax.Infrastructure.Tenant.Modules;

/// <summary>
/// Configura las dependencias de los modulos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddModules(
        this IServiceCollection services)
    {
        services.AddScoped<
            IModuleRepository,
            ModuleRepository>();

        return services;
    }
}