using Prestamax.Domain.Catalogs.DocumentTypes;

namespace Prestamax.Application.Catalogs.DocumentTypes;

/// <summary>
/// Define el contrato para el acceso a los tipos de documento.
/// </summary>
public interface IDocumentTypeRepository
{
    /// <summary>
    /// Obtiene todos los tipos de documento.
    /// </summary>
    Task<IReadOnlyList<DocumentType>> GetAllAsync(
        CancellationToken cancellationToken);
}