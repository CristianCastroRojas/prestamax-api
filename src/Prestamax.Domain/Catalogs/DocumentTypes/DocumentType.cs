namespace Prestamax.Domain.Catalogs.DocumentTypes;

/// <summary>
/// Representa un tipo de documento.
/// </summary>
public sealed class DocumentType
{
    public int IdDocumentType { get; private set; }

    public string Code { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;

    public string Regex { get; private set; } = string.Empty;

    public bool HasVerificationDigit { get; private set; }
}