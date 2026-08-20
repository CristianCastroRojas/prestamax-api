using Microsoft.Extensions.DependencyInjection;
using Prestamax.Infrastructure.Organizations.BusinessDates;
using Prestamax.Infrastructure.Tenant.Modules;
using Prestamax.Infrastructure.Tenant.Organizations;


namespace Prestamax.Infrastructure.Tenant;

/// <summary>
/// Configura las dependencias del módulo Tenant.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddTenantInfrastructure(
        this IServiceCollection services)
    {
        services.AddBusinessDates();

        services.AddModules();

        services.AddOrganizations();

        return services;
    }
}