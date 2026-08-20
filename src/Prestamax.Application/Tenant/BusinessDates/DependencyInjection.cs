using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.BusinessDates.GetBusinessDate;

namespace Prestamax.Application.Tenant.BusinessDates;

/// <summary>
/// Configura las dependencias de fechas de negocio.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddBusinessDates(
        this IServiceCollection services)
    {
        services.AddScoped<GetBusinessDateHandler>();

        return services;
    }
}