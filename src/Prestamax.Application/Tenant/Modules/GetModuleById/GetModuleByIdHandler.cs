namespace Prestamax.Application.Tenant.Modules.GetModuleById;

/// <summary>
/// Obtiene un módulo por su identificador.
/// </summary>
public sealed class GetModuleByIdHandler(
    IModuleRepository repository)
{
    public async Task<GetModuleByIdResponse?> HandleAsync(
        int moduleId,
        CancellationToken cancellationToken)
    {
        var module = await repository.GetByIdAsync(
            moduleId,
            cancellationToken);

        if (module is null)
        {
            return null;
        }

        return new GetModuleByIdResponse(
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