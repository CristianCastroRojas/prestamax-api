namespace Prestamax.Application.Tenant.Modules.GetModules;

/// <summary>
/// Obtiene todos los módulos del sistema.
/// </summary>
public sealed class GetModulesHandler(
    IModuleRepository repository)
{
    public async Task<IReadOnlyList<GetModulesResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var modules = await repository.GetAllAsync(
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