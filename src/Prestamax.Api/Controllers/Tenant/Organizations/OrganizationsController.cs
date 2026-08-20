using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.Organizations.GetOrganizations;

namespace Prestamax.Api.Controllers.Tenant.Organizations;

[ApiController]
[Route("api/organizations")]
public sealed class OrganizationsController(
    GetOrganizationsHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene todas las organizaciones.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetOrganizationsResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(cancellationToken);

        return Ok(response);
    }
}