using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Tenant.Organizations;
using Prestamax.Domain.Tenant.Organizations;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Tenant.Organizations;

/// <summary>
/// Proporciona acceso a las organizaciones.
/// </summary>
public sealed class OrganizationRepository(
    AppDbContext context) : IOrganizationRepository
{
    public async Task<Organization?> GetByIdAsync(
        int idOrganization,
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Organization>()
            .AsNoTracking()
            .FirstOrDefaultAsync(
                x => x.IdOrganization == idOrganization,
                cancellationToken);
    }
}