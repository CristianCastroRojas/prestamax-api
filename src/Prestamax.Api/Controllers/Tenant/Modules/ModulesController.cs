using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.Modules.GetModuleById;
using Prestamax.Application.Tenant.Modules.GetModules;

namespace Prestamax.Api.Controllers.Tenant.Modules;

[ApiController]
[Route("api/modules")]
public sealed class ModulesController(
    GetModulesHandler getModulesHandler,
    GetModuleByIdHandler getModuleByIdHandler) : ControllerBase
{
    /// <summary>
    /// Obtiene todos los módulos de la organización actual.
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
    /// Obtiene un módulo mediante su identificador.
    /// </summary>
    [HttpGet("{moduleId:int}")]
    public async Task<ActionResult<GetModuleByIdResponse>> GetById(
        int moduleId,
        CancellationToken cancellationToken)
    {
        var response = await getModuleByIdHandler.HandleAsync(
            moduleId,
            cancellationToken);

        if (response is null)
        {
            return NotFound();
        }

        return Ok(response);
    }
}