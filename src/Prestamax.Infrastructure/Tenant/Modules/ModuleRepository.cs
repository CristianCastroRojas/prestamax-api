using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Tenant.Modules;
using Prestamax.Domain.Tenant.Modules;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Tenant.Modules;

/// <summary>
/// Proporciona acceso a los módulos de navegación.
/// </summary>
public sealed class ModuleRepository(
    AppDbContext context) : IModuleRepository
{
    public async Task<IReadOnlyList<Module>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Module>()
            .AsNoTracking()
            .OrderBy(x => x.DisplayOrder)
            .ToListAsync(cancellationToken);
    }

    public async Task<Module?> GetByIdAsync(
        int moduleId,
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Module>()
            .AsNoTracking()
            .FirstOrDefaultAsync(
                x => x.IdModule == moduleId,
                cancellationToken);
    }
}