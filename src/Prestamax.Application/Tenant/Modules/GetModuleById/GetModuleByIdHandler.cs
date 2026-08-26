using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Tenant.Modules.Errors;
using Prestamax.Application.Tenant.Organizations;
using Prestamax.Application.Tenant.Organizations.Common;

namespace Prestamax.Application.Tenant.Modules.GetModuleById;

/// <summary>
/// Obtiene un módulo por su identificador.
/// </summary>
public sealed class GetModuleByIdHandler(
    IModuleRepository repository,
    IOrganizationValidator organizationValidator)
{
    public async Task<GetModuleByIdResponse?> HandleAsync(
        int organizationId,
        int moduleId,
        CancellationToken cancellationToken)
    {
        await organizationValidator.EnsureExistsAsync(
            organizationId,
            cancellationToken);

        var module = await repository.GetByIdAsync(
            organizationId,
            moduleId,
            cancellationToken);

        return module is null
            ? throw new NotFoundException(ModuleErrors.NotFound)
            : new GetModuleByIdResponse(
                module.IdModule,
                module.IdOrganization,
                module.IdParentModule,
                module.Code,
                module.Name,
                module.Route,
                module.Icon,
                module.DisplayOrder,
                module.IsActive,
                module.CreatedAt,
                module.UpdatedAt);
    }
}