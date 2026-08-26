using Prestamax.Application.Tenant.Organizations;
using Prestamax.Application.Tenant.Organizations.Common;

namespace Prestamax.Application.Tenant.Modules.GetModules;

/// <summary>
/// Obtiene todos los módulos activos de una organización.
/// </summary>
public sealed class GetModulesHandler(
    IModuleRepository repository,
    IOrganizationValidator organizationValidator)
{
    public async Task<IReadOnlyList<GetModulesResponse>> HandleAsync(
        int organizationId,
        CancellationToken cancellationToken)
    {
        await organizationValidator.EnsureExistsAsync(
            organizationId,
            cancellationToken);

        var modules = await repository.GetAllAsync(
            organizationId,
            cancellationToken);

        return [.. modules.Select(module => new GetModulesResponse(
            module.IdModule,
            module.Code,
            module.Name,
            module.Icon,
            module.IsActive,
            module.UpdatedAt))];
    }
}