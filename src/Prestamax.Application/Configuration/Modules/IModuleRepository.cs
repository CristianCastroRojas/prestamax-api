using Prestamax.Domain.Configuration;

namespace Prestamax.Application.Configuration.Modules;

/// <summary>
/// Define el contrato para el acceso a los módulos.
/// </summary>
public interface IModuleRepository
{
    /// <summary>
    /// Obtiene todos los módulos.
    /// </summary>
    Task<IReadOnlyList<Module>> GetAllAsync(
        CancellationToken cancellationToken);
}