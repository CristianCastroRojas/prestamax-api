using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Tenant.BusinessDates.Errors;
using Prestamax.Application.Tenant.Organizations.Common;

namespace Prestamax.Application.Tenant.BusinessDates.GetBusinessDate;

/// <summary>
/// Obtiene la fecha de negocio de una organización.
/// </summary>
public sealed class GetBusinessDateHandler(
    IBusinessDateRepository repository,
    IOrganizationValidator organizationValidator)
{
    public async Task<GetBusinessDateResponse?> HandleAsync(
        int organizationId,
        CancellationToken cancellationToken)
    {
        await organizationValidator.EnsureExistsAsync(
            organizationId,
            cancellationToken);

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