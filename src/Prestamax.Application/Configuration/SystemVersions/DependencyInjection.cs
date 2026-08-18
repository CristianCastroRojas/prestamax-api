using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Configuration.SystemVersions.GetSystemVersions;

namespace Prestamax.Application.Configuration.SystemVersions;

/// <summary>
/// Configura las dependencias de las versiones del sistema.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddSystemVersions(
        this IServiceCollection services)
    {
        services.AddScoped<GetSystemVersionsHandler>();

        return services;
    }
}