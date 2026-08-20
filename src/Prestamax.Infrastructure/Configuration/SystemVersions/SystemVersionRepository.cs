using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Configuration.SystemVersions;
using Prestamax.Domain.Configuration.SystemVersions;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Configuration.SystemVersions;

/// <summary>
/// Proporciona acceso a las versiones del sistema.
/// </summary>
public sealed class SystemVersionRepository(
    AppDbContext context) : ISystemVersionRepository
{
    public async Task<IReadOnlyList<SystemVersion>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<SystemVersion>()
            .AsNoTracking()
            .OrderByDescending(x => x.UpdatedAt)
            .ToListAsync(cancellationToken);
    }
}