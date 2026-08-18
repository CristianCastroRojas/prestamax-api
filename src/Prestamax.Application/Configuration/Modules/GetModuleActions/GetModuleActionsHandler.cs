using Prestamax.Application.Configuration.Modules;

namespace Prestamax.Application.Configuration.Modules.GetModuleActions;

/// <summary>
/// Obtiene las acciones disponibles de un módulo.
/// </summary>
public sealed class GetModuleActionsHandler(
    IModuleActionRepository repository)
{
    public async Task<IReadOnlyList<GetModuleActionsResponse>> HandleAsync(
        long moduleId,
        CancellationToken cancellationToken)
    {
        var moduleActions = await repository.GetByModuleIdAsync(
            moduleId,
            cancellationToken);

        return [.. moduleActions
            .Select(moduleAction => new GetModuleActionsResponse(
                moduleAction.IdModuleAction,
                moduleAction.IdModule,
                moduleAction.Code,
                moduleAction.Name,
                moduleAction.Description))];
    }
}