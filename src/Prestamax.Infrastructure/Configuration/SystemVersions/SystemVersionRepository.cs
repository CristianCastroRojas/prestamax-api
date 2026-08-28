using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Configuration.SystemVersions;
using Prestamax.Domain.Configuration.SystemVersions;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Configuration.SystemVersions;

/// <summary>
/// Proporciona acceso a la versión vigente del sistema.
/// </summary>
public sealed class SystemVersionRepository(
    AppDbContext context) : ISystemVersionRepository
{
    public async Task<SystemVersion?> GetCurrentAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<SystemVersion>()
            .AsNoTracking()
            .FirstOrDefaultAsync(
                x => x.IsCurrent,
                cancellationToken);
    }
}