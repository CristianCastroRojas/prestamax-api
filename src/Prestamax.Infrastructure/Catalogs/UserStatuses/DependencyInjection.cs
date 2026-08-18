using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Catalogs.UserStatuses;

namespace Prestamax.Infrastructure.Catalogs.UserStatuses;

/// <summary>
/// Configura las dependencias de los estados de usuario.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddUserStatuses(
        this IServiceCollection services)
    {
        services.AddScoped<
            IUserStatusRepository,
            UserStatusRepository>();

        return services;
    }
}