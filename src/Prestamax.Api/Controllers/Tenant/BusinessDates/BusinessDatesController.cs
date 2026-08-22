using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.BusinessDates.GetBusinessDate;

namespace Prestamax.Api.Controllers.Tenant.BusinessDates;

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
        int organizationId,
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(
            organizationId,
            cancellationToken);

        return Ok(response);
    }
}