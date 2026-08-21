using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Tenant.Organizations.GetOrganizationById;

namespace Prestamax.Api.Controllers.Tenant.Organizations;

[ApiController]
[Route("api/organization")]
public sealed class OrganizationsController(
    GetOrganizationByIdHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene una organización por su identificador.
    /// </summary>
    [HttpGet("{idOrganization:int}")]
    public async Task<ActionResult<GetOrganizationByIdResponse>> GetById(
        int idOrganization,
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(
            idOrganization,
            cancellationToken);

        return Ok(response);
    }
}