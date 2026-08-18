namespace Prestamax.Application.Organizations.GetOrganizations;

/// <summary>
/// Obtiene todas las organizaciones.
/// </summary>
public sealed class GetOrganizationsHandler(
    IOrganizationRepository repository)
{
    public async Task<IReadOnlyList<GetOrganizationsResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var organizations = await repository.GetAllAsync(cancellationToken);

        return [.. organizations
            .Select(organization => new GetOrganizationsResponse(
                organization.IdOrganization,
                organization.Name,
                organization.DocumentNumber,
                organization.Email,
                organization.Phone,
                organization.Address,
                organization.UpdatedAt))];
    }
}