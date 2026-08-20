using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.Modules.GetModuleById;
using Prestamax.Application.Tenant.Modules.GetModules;

namespace Prestamax.Application.Tenant.Modules;

/// <summary>
/// Configura las dependencias de modulos.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddModules(
        this IServiceCollection services)
    {
        services.AddScoped<GetModulesHandler>();
        services.AddScoped<GetModuleByIdHandler>();

        return services;
    }
}