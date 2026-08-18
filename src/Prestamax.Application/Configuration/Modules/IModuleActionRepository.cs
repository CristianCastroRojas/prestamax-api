using Prestamax.Domain.Configuration;

namespace Prestamax.Application.Configuration.Modules;

/// <summary>
/// Define el contrato para el acceso a las acciones de los módulos.
/// </summary>
public interface IModuleActionRepository
{
    /// <summary>
    /// Obtiene las acciones de un módulo.
    /// </summary>
    Task<IReadOnlyList<ModuleAction>> GetByModuleIdAsync(
        long moduleId,
        CancellationToken cancellationToken);
}