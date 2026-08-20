using Prestamax.Domain.Tenant.Modules;

namespace Prestamax.Application.Tenant.Modules;

/// <summary>
/// Contrato para la consulta de módulos.
/// </summary>
public interface IModuleRepository
{
    /// <summary>
    /// Obtiene los módulos disponibles.
    /// </summary>
    Task<IReadOnlyList<Module>> GetAllAsync(
        CancellationToken cancellationToken);

    /// <summary>
    /// Obtiene un módulo mediante su identificador.
    /// </summary>
    Task<Module?> GetByIdAsync(
        int moduleId,
        CancellationToken cancellationToken);
}