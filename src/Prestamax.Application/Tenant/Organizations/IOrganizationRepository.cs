using Prestamax.Domain.Tenant.Organizations;

namespace Prestamax.Application.Tenant.Organizations;

/// <summary>
/// Define el contrato para el acceso a las organizaciones.
/// </summary>
public interface IOrganizationRepository
{
    /// <summary>
    /// Obtiene una organización por su identificador.
    /// </summary>
    Task<Organization?> GetByIdAsync(
        int idOrganization,
        CancellationToken cancellationToken);

    /// <summary>
    /// Verifica si existe una organización por su identificador.
    /// </summary>
    Task<bool> ExistsAsync(
        int idOrganization,
        CancellationToken cancellationToken);
}