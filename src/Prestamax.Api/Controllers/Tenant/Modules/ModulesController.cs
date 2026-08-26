using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.Modules.GetModuleById;
using Prestamax.Application.Tenant.Modules.GetModules;

namespace Prestamax.Api.Controllers.Tenant.Modules;

[ApiController]
[Route("api/organizations/{organizationId:int}/modules")]
public sealed class ModulesController(
    GetModulesHandler getModulesHandler,
    GetModuleByIdHandler getModuleByIdHandler) : ControllerBase
{
    /// <summary>
    /// Obtiene todos los módulos activos de una organización.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetModulesResponse>>> GetAll(
        int organizationId,
        CancellationToken cancellationToken)
    {
        var response = await getModulesHandler.HandleAsync(
            organizationId,
            cancellationToken);

        return Ok(response);
    }

    /// <summary>
    /// Obtiene un módulo mediante su identificador dentro de una organización.
    /// </summary>
    [HttpGet("{moduleId:int}")]
    public async Task<ActionResult<GetModuleByIdResponse>> GetById(
        int organizationId,
        int moduleId,
        CancellationToken cancellationToken)
    {
        var response = await getModuleByIdHandler.HandleAsync(
            organizationId,
            moduleId,
            cancellationToken);

        return Ok(response);
    }
}