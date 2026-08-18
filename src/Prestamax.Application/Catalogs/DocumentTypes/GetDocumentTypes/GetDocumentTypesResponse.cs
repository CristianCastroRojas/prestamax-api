namespace Prestamax.Application.Catalogs.DocumentTypes.GetDocumentTypes;

/// <summary>
/// Representa la respuesta con la información de un tipo de documento.
/// </summary>
public sealed record GetDocumentTypesResponse(
    long IdDocumentType,
    string Code,
    string Name,
    string Regex);