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
        int organizationId,
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Module>()
            .AsNoTracking()
            .Where(x => x.IdOrganization == organizationId && x.IsActive)
            .OrderBy(x => x.DisplayOrder)
            .ToListAsync(cancellationToken);
    }
}