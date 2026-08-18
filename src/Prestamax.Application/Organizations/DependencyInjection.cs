using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Organizations.GetBusinessDate;
using Prestamax.Application.Organizations.GetOrganizations;

namespace Prestamax.Application.Organizations;

/// <summary>
/// Configura las dependencias de las organizaciones.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddOrganizations(
        this IServiceCollection services)
    {
        services.AddScoped<GetOrganizationsHandler>();

        services.AddScoped<GetBusinessDateHandler>();

        return services;
    }
}