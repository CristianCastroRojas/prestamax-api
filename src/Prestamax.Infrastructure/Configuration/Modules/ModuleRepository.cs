using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Configuration.Modules;
using Prestamax.Domain.Configuration;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Configuration.Modules;

/// <summary>
/// Proporciona acceso a los módulos.
/// </summary>
public sealed class ModuleRepository(
    AppDbContext context) : IModuleRepository
{
    /// <summary>
    /// Obtiene todos los módulos.
    /// </summary>
    public async Task<IReadOnlyList<Module>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Module>()
            .AsNoTracking()
            .OrderBy(x => x.DisplayOrder)
            .ToListAsync(cancellationToken);
    }
}