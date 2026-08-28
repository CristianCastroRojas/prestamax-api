using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.Modules.GetModules;

namespace Prestamax.Api.Controllers.Tenant.Modules;

[ApiController]
[Route("api/organizations/{organizationId:int}/modules")]
public sealed class ModulesController(
    GetModulesHandler getModulesHandler) : ControllerBase
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
}