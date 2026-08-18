namespace Prestamax.Application.Organizations.GetBusinessDate;

/// <summary>
/// Obtiene la fecha de negocio de una organización.
/// </summary>
public sealed class GetBusinessDateHandler(
    IBusinessDateRepository repository)
{
    public async Task<GetBusinessDateResponse?> HandleAsync(
        long organizationId,
        CancellationToken cancellationToken)
    {
        var businessDate = await repository.GetByOrganizationIdAsync(
            organizationId,
            cancellationToken);

        if (businessDate is null)
        {
            return null;
        }

        return new GetBusinessDateResponse(
            businessDate.IdBusinessDate,
            businessDate.IdOrganization,
            businessDate.Date,
            businessDate.UpdatedAt);
    }
}