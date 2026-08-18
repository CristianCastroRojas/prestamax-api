using Prestamax.Domain.Configuration;

namespace Prestamax.Application.Configuration.SystemVersions;

/// <summary>
/// Define el contrato para el acceso a las versiones del sistema.
/// </summary>
public interface ISystemVersionRepository
{
    /// <summary>
    /// Obtiene todas las versiones del sistema.
    /// </summary>
    Task<IReadOnlyList<SystemVersion>> GetAllAsync(
        CancellationToken cancellationToken);
}