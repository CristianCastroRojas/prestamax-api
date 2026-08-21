using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Tenant.Organizations.Common;
using Prestamax.Application.Tenant.Organizations.Errors;

namespace Prestamax.Application.Tenant.Organizations.GetOrganizationById;

/// <summary>
/// Obtiene una organización por su identificador.
/// </summary>
public sealed class GetOrganizationByIdHandler(
    IOrganizationRepository repository)
{
    public async Task<GetOrganizationByIdResponse> HandleAsync(
        int idOrganization,
        CancellationToken cancellationToken)
    {
        var organization = await repository.GetByIdAsync(
            idOrganization,
            cancellationToken);

        if (organization is null)
        {
            throw new NotFoundException(
                OrganizationErrors.NotFound);
        }

        return new GetOrganizationByIdResponse(
            organization.IdOrganization,
            organization.LegalName,
            organization.CommercialName,
            organization.IdDocumentType,
            organization.DocumentNumber,
            organization.Email,
            organization.Phone,
            organization.Address,
            organization.CreatedAt,
            organization.UpdatedAt);
    }
}