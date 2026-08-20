using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;

namespace Prestamax.Application.Catalogs.UserStatuses;

/// <summary>
/// Configura las dependencias de los estados de usuario.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddUserStatuses(
        this IServiceCollection services)
    {
        services.AddScoped<GetManualUserStatusesHandler>();

        return services;
    }
}