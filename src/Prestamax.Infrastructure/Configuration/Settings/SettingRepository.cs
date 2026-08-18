using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Configuration.Settings;
using Prestamax.Domain.Configuration;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Configuration.Settings;

/// <summary>
/// Proporciona acceso a las configuraciones.
/// </summary>
public sealed class SettingRepository(
    AppDbContext context) : ISettingRepository
{
    public async Task<string?> GetValueAsync(
        long organizationId,
        string settingKey,
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Setting>()
            .AsNoTracking()
            .Where(x =>
                x.IdOrganization == organizationId &&
                x.SettingKey == settingKey)
            .Select(x => x.SettingValue)
            .SingleOrDefaultAsync(cancellationToken);
    }
}