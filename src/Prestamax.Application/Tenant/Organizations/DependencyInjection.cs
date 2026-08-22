using Microsoft.Extensions.DependencyInjection;
using Prestamax.Application.Tenant.Organizations.Common;
using Prestamax.Application.Tenant.Organizations.GetOrganizationById;

namespace Prestamax.Application.Tenant.Organizations;

/// <summary>
/// Configura las dependencias de organizaciones.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddOrganizations(
        this IServiceCollection services)
    {
        services.AddScoped<GetOrganizationByIdHandler>();

        services.AddScoped<IOrganizationValidator, OrganizationValidator>();

        return services;
    }
}