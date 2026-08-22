using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Configuration.SystemVersions.GetCurrentSystemVersion;

namespace Prestamax.Api.Controllers.Configuration.SystemVersions;

[ApiController]
[Route("api/configuration/system-version")]
public sealed class SystemVersionsController(
    GetCurrentSystemVersionHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene la versión vigente del sistema.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<GetCurrentSystemVersionResponse>> GetCurrent(
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(cancellationToken);

        return Ok(response);
    }
}