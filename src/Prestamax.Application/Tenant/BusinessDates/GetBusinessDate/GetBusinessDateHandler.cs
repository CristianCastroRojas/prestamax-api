using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Tenant.BusinessDates.Errors;
using Prestamax.Application.Tenant.Organizations;
using Prestamax.Application.Tenant.Organizations.Errors;

namespace Prestamax.Application.Tenant.BusinessDates.GetBusinessDate;

/// <summary>
/// Obtiene la fecha de negocio de una organización.
/// </summary>
public sealed class GetBusinessDateHandler(
    IBusinessDateRepository repository,
    IOrganizationRepository organizationRepository)
{
    public async Task<GetBusinessDateResponse> HandleAsync(
        int organizationId,
        CancellationToken cancellationToken)
    {
        var organizationExists = await organizationRepository.ExistsAsync(
            organizationId,
            cancellationToken);

        if (!organizationExists)
        {
            throw new NotFoundException(
                OrganizationErrors.NotFound);
        }

        var businessDate = await repository.GetByOrganizationIdAsync(
            organizationId,
            cancellationToken);

        return businessDate is null
            ? throw new NotFoundException(
                BusinessDateErrors.NotFound)
            : new GetBusinessDateResponse(
            businessDate.IdBusinessDate,
            businessDate.IdOrganization,
            businessDate.Date,
            businessDate.UpdatedAt);
    }
}