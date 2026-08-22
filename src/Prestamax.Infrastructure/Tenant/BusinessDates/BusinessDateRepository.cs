using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Tenant.BusinessDates;
using Prestamax.Domain.Organizations.BusinessDates;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Tenant.BusinessDates;

/// <summary>
/// Proporciona acceso a las fechas de negocio.
/// </summary>
public sealed class BusinessDateRepository(
    AppDbContext context) : IBusinessDateRepository
{
    public async Task<BusinessDate?> GetByOrganizationIdAsync(
        int organizationId,
        CancellationToken cancellationToken)
    {
        return await context
            .Set<BusinessDate>()
            .AsNoTracking()
            .SingleOrDefaultAsync(
                x => x.IdOrganization == organizationId,
                cancellationToken);
    }
}