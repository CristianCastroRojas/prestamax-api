using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.BusinessDates.GetBusinessDate;

namespace Prestamax.Api.Controllers.Organizations.BusinessDates;

[ApiController]
[Route("api/organizations/{organizationId:int}/business-date")]
public sealed class BusinessDatesController(
    GetBusinessDateHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene la fecha de negocio vigente de una organización.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<GetBusinessDateResponse>> Get(
        long organizationId,
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(
            organizationId,
            cancellationToken);

        if (response is null)
        {
            return NotFound();
        }

        return Ok(response);
    }
}