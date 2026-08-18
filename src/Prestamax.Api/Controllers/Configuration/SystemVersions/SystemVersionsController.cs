using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Configuration.SystemVersions.GetSystemVersions;

namespace Prestamax.Api.Controllers.Configuration.SystemVersions;

[ApiController]
[Route("api/configuration/system-versions")]
public sealed class SystemVersionsController(
    GetSystemVersionsHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene todas las versiones del sistema.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetSystemVersionsResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(cancellationToken);

        return Ok(response);
    }
}