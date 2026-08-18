namespace Prestamax.Application.Configuration.Modules.GetModules;

/// <summary>
/// Obtiene todos los módulos.
/// </summary>
public sealed class GetModulesHandler(
    IModuleRepository repository)
{
    public async Task<IReadOnlyList<GetModulesResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var modules = await repository.GetAllAsync(
            cancellationToken);

        return [.. modules
            .Select(module => new GetModulesResponse(
                module.IdModule,
                module.IdParentModule,
                module.Code,
                module.Name,
                module.Description,
                module.DisplayOrder))];
    }
}