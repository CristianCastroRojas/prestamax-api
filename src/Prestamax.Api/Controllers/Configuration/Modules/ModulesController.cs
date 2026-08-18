using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Configuration.Modules.GetModuleActions;
using Prestamax.Application.Configuration.Modules.GetModules;

namespace Prestamax.Api.Controllers.Configuration.Modules;

[ApiController]
[Route("api/configuration/modules")]
public sealed class ModulesController(
    GetModulesHandler getModulesHandler,
    GetModuleActionsHandler getModuleActionsHandler) : ControllerBase
{
    /// <summary>
    /// Obtiene todos los módulos.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetModulesResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var response = await getModulesHandler.HandleAsync(
            cancellationToken);

        return Ok(response);
    }

    /// <summary>
    /// Obtiene las acciones disponibles de un módulo.
    /// </summary>
    [HttpGet("{moduleId:long}/actions")]
    public async Task<ActionResult<IReadOnlyList<GetModuleActionsResponse>>> GetActions(
        long moduleId,
        CancellationToken cancellationToken)
    {
        var response = await getModuleActionsHandler.HandleAsync(
            moduleId,
            cancellationToken);

        return Ok(response);
    }
}