using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;
using Prestamax.Application.Catalogs.UserStatuses.GetUserStatuses;

namespace Prestamax.Application.Catalogs.UserStatuses;

/// <summary>
/// Configura las dependencias de los estados de usuario.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddUserStatuses(
        this IServiceCollection services)
    {
        services.AddScoped<GetUserStatusesHandler>();

        services.AddScoped<GetManualUserStatusesHandler>();

        return services;
    }
}