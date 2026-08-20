using Prestamax.Domain.Organizations.BusinessDates;

namespace Prestamax.Application.Tenant.BusinessDates;

/// <summary>
/// Define el contrato para el acceso a la fecha de negocio.
/// </summary>
public interface IBusinessDateRepository
{
    /// <summary>
    /// Obtiene la fecha de negocio de una organización.
    /// </summary>
    Task<BusinessDate?> GetByOrganizationIdAsync(
        long organizationId,
        CancellationToken cancellationToken);
}