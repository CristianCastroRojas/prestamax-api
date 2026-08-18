using Prestamax.Domain.Catalogs.UserStatuses;

namespace Prestamax.Application.Catalogs.UserStatuses;

/// <summary>
/// Define el contrato para el acceso a los estados de usuario.
/// </summary>
public interface IUserStatusRepository
{
    /// <summary>
    /// Obtiene todos los estados de usuario.
    /// </summary>
    Task<IReadOnlyList<UserStatus>> GetAllAsync(
        CancellationToken cancellationToken);

    /// <summary>
    /// Obtiene los estados de usuario permitidos para selección manual.
    /// </summary>
    Task<IReadOnlyList<UserStatus>> GetManualSelectionAsync(
        CancellationToken cancellationToken);
}