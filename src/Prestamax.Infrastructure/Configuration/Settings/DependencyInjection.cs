using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Configuration.Settings;

namespace Prestamax.Infrastructure.Configuration.Settings;

/// <summary>
/// Configura las dependencias de las configuraciones.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddSettings(
        this IServiceCollection services)
    {
        services.AddScoped<
            ISettingRepository,
            SettingRepository>();

        return services;
    }
}