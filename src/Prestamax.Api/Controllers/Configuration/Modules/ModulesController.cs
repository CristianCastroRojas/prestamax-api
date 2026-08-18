using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Configuration.Modules.GetModules;

namespace Prestamax.Api.Controllers.Configuration.Modules;

[ApiController]
[Route("api/configuration/modules")]
public sealed class ModulesController(
    GetModulesHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene todos los módulos.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetModulesResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(cancellationToken);

        return Ok(response);
    }
}