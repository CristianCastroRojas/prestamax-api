using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Organizations;

namespace Prestamax.Infrastructure.Organizations.BusinessDates;

/// <summary>
/// Configura las dependencias de las fechas de negocio.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddBusinessDates(
        this IServiceCollection services)
    {
        services.AddScoped<
            IBusinessDateRepository,
            BusinessDateRepository>();

        return services;
    }
}