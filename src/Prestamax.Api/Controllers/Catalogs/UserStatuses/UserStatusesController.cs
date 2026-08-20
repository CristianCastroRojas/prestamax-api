using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;

namespace Prestamax.Api.Controllers.Catalogs.UserStatuses;

[ApiController]
[Route("api/catalogs/user-statuses")]
public sealed class UserStatusesController(
    GetManualUserStatusesHandler manualHandler) : ControllerBase
{
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