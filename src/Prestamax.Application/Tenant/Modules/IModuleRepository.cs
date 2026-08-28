using Prestamax.Domain.Tenant.Modules;

namespace Prestamax.Application.Tenant.Modules;

/// <summary>
/// Contrato para la consulta de módulos.
/// </summary>
public interface IModuleRepository
{
    /// <summary>
    /// Obtiene los módulos activos de una organización.
    /// </summary>
    Task<IReadOnlyList<Module>> GetAllAsync(
        int organizationId,
        CancellationToken cancellationToken);
}