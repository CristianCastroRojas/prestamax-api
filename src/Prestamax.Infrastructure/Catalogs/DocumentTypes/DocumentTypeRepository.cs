using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Catalogs.DocumentTypes;
using Prestamax.Domain.Catalogs.DocumentTypes;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Catalogs.DocumentTypes;

/// <summary>
/// Proporciona acceso a los tipos de documento.
/// </summary>
public sealed class DocumentTypeRepository(
    AppDbContext context) : IDocumentTypeRepository
{
    public async Task<IReadOnlyList<DocumentType>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<DocumentType>()
            .AsNoTracking()
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
    }
}