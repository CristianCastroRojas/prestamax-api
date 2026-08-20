using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.BusinessDates;
using Prestamax.Infrastructure.Tenant.BusinessDates;

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