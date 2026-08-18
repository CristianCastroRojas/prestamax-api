using Microsoft.AspNetCore.Mvc;
using Prestamax.Application.Catalogs.DocumentTypes.GetDocumentTypes;

namespace Prestamax.Api.Controllers.Catalogs.DocumentTypes;

[ApiController]
[Route("api/catalogs/document-types")]
public sealed class DocumentTypesController(
    GetDocumentTypesHandler handler) : ControllerBase
{
    /// <summary>
    /// Obtiene todos los tipos de documento disponibles.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<GetDocumentTypesResponse>>> GetAll(
        CancellationToken cancellationToken)
    {
        var response = await handler.HandleAsync(cancellationToken);

        return Ok(response);
    }
}