using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Tenant.Organizations;
using Prestamax.Application.Tenant.Organizations.Errors;
using Prestamax.Domain.Tenant.Modules;

namespace Prestamax.Application.Tenant.Modules.GetModules;

/// <summary>
/// Obtiene los módulos activos de una organización
/// construidos en una estructura jerárquica.
/// </summary>
public sealed class GetModulesHandler(
    IModuleRepository repository,
    IOrganizationRepository organizationRepository)
{
    public async Task<IReadOnlyList<GetModulesResponse>> HandleAsync(
        int organizationId,
        CancellationToken cancellationToken)
    {
        var organizationExists = await organizationRepository.ExistsAsync(
            organizationId,
            cancellationToken);

        if (!organizationExists)
        {
            throw new NotFoundException(
                OrganizationErrors.NotFound);
        }

        var modules = await repository.GetAllAsync(
            organizationId,
            cancellationToken);

        return BuildTree(modules);
    }

    private static IReadOnlyList<GetModulesResponse> BuildTree(
        IReadOnlyList<Module> modules)
    {
        var lookup = modules.ToLookup(x => x.IdParentModule);

        return BuildChildren(null, lookup);
    }

    private static IReadOnlyList<GetModulesResponse> BuildChildren(
        int? parentId,
        ILookup<int?, Module> lookup)
    {
        return
        [
            .. lookup[parentId]
                .OrderBy(x => x.DisplayOrder)
                .Select(module => new GetModulesResponse(
                    module.IdModule,
                    module.Code,
                    module.Name,
                    module.Route,
                    module.Icon,
                    module.IsActive,
                    BuildChildren(module.IdModule, lookup)))
        ];
    }
}