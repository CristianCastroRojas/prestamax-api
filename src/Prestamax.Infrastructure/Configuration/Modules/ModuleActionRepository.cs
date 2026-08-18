using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Configuration.Modules;
using Prestamax.Domain.Configuration;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Configuration.Modules;

/// <summary>
/// Proporciona acceso a las acciones de los módulos.
/// </summary>
public sealed class ModuleActionRepository(
    AppDbContext context) : IModuleActionRepository
{
    public async Task<IReadOnlyList<ModuleAction>> GetByModuleIdAsync(
        long moduleId,
        CancellationToken cancellationToken)
    {
        return await context
            .Set<ModuleAction>()
            .AsNoTracking()
            .Where(x => x.IdModule == moduleId)
            .OrderBy(x => x.IdModuleAction)
            .ToListAsync(cancellationToken);
    }
}