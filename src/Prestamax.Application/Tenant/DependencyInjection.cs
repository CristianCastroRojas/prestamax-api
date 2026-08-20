using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.BusinessDates;
using Prestamax.Application.Tenant.Modules;
using Prestamax.Application.Tenant.Organizations;

namespace Prestamax.Application.Tenant;

/// <summary>
/// Configura las dependencias del módulo Tenant.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddTenantApplication(
        this IServiceCollection services)
    {
        services.AddOrganizations();

        services.AddBusinessDates();

        services.AddModules();

        return services;
    }
}