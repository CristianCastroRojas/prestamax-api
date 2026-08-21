using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.Organizations.Common;

namespace Prestamax.Infrastructure.Tenant.Organizations;

/// <summary>
/// Configura las dependencias de las organizaciones.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddOrganizations(
        this IServiceCollection services)
    {
        services.AddScoped<
            IOrganizationRepository,
            OrganizationRepository>();

        return services;
    }
}