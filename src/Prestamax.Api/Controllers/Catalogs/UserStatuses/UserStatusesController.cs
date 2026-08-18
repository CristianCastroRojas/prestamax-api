using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;
using Prestamax.Application.Catalogs.UserStatuses.GetUserStatuses;

namespace Prestamax.Api.Controllers.Catalogs.UserStatuses;

[ApiController]
[Route("api/catalogs/user-statuses")]
public sealed class UserStatusesController(
    GetUserStatusesHandler handler,
    GetManualUserStatusesHandler manualHandler) : ControllerBase
{
    /// <summary>
    /// Obtiene todos los estados de usuario.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetUserStatusesResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(cancellationToken);

        return Ok(response);
    }

    /// <summary>
    /// Obtiene los estados de usuario permitidos para selección manual.
    /// </summary>
    [HttpGet("manual-selection")]
    public async Task<ActionResult<IReadOnlyList<GetManualUserStatusesResponse>>> GetManualSelection(
        CancellationToken cancellationToken)
    {
        var response = await manualHandler.HandleAsync(cancellationToken);

        return Ok(response);
    }
}