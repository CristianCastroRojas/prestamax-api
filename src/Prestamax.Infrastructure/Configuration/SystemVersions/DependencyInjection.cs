using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Configuration.SystemVersions;

namespace Prestamax.Infrastructure.Configuration.SystemVersions;

/// <summary>
/// Configura las dependencias de las versiones del sistema.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddSystemVersions(
        this IServiceCollection services)
    {
        services.AddScoped<
            ISystemVersionRepository,
            SystemVersionRepository>();

        return services;
    }
}