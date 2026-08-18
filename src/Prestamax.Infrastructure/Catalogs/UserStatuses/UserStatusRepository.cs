using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Catalogs.UserStatuses;
using Prestamax.Domain.Catalogs.UserStatuses;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Catalogs.UserStatuses;

/// <summary>
/// Proporciona acceso a los estados de usuario.
/// </summary>
public sealed class UserStatusRepository(
    AppDbContext context) : IUserStatusRepository
{
    /// <summary>
    /// Obtiene todos los estados de usuario.
    /// </summary>
    public async Task<IReadOnlyList<UserStatus>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<UserStatus>()
            .AsNoTracking()
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Obtiene los estados de usuario permitidos para selección manual.
    /// </summary>
    public async Task<IReadOnlyList<UserStatus>> GetManualSelectionAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<UserStatus>()
            .AsNoTracking()
            .Where(x => x.AllowManualSelection)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
    }
}