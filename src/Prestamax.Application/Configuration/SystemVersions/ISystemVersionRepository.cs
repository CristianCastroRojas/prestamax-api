using Prestamax.Domain.Configuration.SystemVersions;

namespace Prestamax.Application.Configuration.SystemVersions;

/// <summary>
/// Define el contrato para el acceso a las versiones del sistema.
/// </summary>
public interface ISystemVersionRepository
{
    /// <summary>
    /// Obtiene la versión vigente del sistema.
    /// </summary>
    Task<SystemVersion?> GetCurrentAsync(
        CancellationToken cancellationToken);
}