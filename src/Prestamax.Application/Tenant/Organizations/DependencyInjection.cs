using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.Organizations.GetOrganizations;

namespace Prestamax.Application.Tenant.Organizations;

/// <summary>
/// Configura las dependencias de organizaciones.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddOrganizations(
        this IServiceCollection services)
    {
        services.AddScoped<GetOrganizationsHandler>();

        return services;
    }
}