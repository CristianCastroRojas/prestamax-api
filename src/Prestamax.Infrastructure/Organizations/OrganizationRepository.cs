using Microsoft.EntityFrameworkCore;
using Prestamax.Application.Organizations;
using Prestamax.Domain.Organizations;
using Prestamax.Infrastructure.Persistence;

namespace Prestamax.Infrastructure.Organizations;

/// <summary>
/// Proporciona acceso a las organizaciones.
/// </summary>
public sealed class OrganizationRepository(
    AppDbContext context) : IOrganizationRepository
{
    public async Task<IReadOnlyList<Organization>> GetAllAsync(
        CancellationToken cancellationToken)
    {
        return await context
            .Set<Organization>()
            .AsNoTracking()
            .OrderBy(x => x.IdOrganization)
            .ToListAsync(cancellationToken);
    }
}