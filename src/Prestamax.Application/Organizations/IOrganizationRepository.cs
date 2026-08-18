using Prestamax.Domain.Organizations;

namespace Prestamax.Application.Organizations;

/// <summary>
/// Define el contrato para el acceso a las organizaciones.
/// </summary>
public interface IOrganizationRepository
{
    /// <summary>
    /// Obtiene todas las organizaciones.
    /// </summary>
    Task<IReadOnlyList<Organization>> GetAllAsync(
        CancellationToken cancellationToken);
}