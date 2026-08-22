using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Tenant.Organizations.Errors;

namespace Prestamax.Application.Tenant.Organizations.Common;

/// <summary>
/// Proporciona validaciones relacionadas con las organizaciones.
/// </summary>
public sealed class OrganizationValidator(
    IOrganizationRepository repository) : IOrganizationValidator
{
    public async Task EnsureExistsAsync(
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
    }
}