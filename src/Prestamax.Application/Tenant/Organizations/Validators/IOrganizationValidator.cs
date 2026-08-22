namespace Prestamax.Application.Tenant.Organizations.Common;

/// <summary>
/// Define las validaciones relacionadas con las organizaciones.
/// </summary>
public interface IOrganizationValidator
{
    /// <summary>
    /// Verifica que la organización exista.
    /// </summary>
    Task EnsureExistsAsync(
        int idOrganization,
        CancellationToken cancellationToken);
}