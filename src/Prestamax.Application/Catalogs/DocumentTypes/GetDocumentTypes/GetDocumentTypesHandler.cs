namespace Prestamax.Application.Catalogs.DocumentTypes.GetDocumentTypes;

/// <summary>
/// Obtiene todos los tipos de documento.
/// </summary>
public sealed class GetDocumentTypesHandler(
    IDocumentTypeRepository repository)
{
    public async Task<IReadOnlyList<GetDocumentTypesResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var documentTypes = await repository.GetAllAsync(cancellationToken);

        return [.. documentTypes
            .Select(documentType => new GetDocumentTypesResponse(
                documentType.IdDocumentType,
                documentType.Code,
                documentType.Name,
                documentType.Regex,
                documentType.HasVerificationDigit))];
    }
}