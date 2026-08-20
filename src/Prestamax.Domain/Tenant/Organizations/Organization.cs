namespace Prestamax.Domain.Tenant.Organizations;

/// <summary>
/// Representa una organización que utiliza el sistema.
/// </summary>
public sealed class Organization
{
    public int IdOrganization { get; private set; }

    public string LegalName { get; private set; } = string.Empty;

    public string? CommercialName { get; private set; }

    public int IdDocumentType { get; private set; }

    public string DocumentNumber { get; private set; } = string.Empty;

    public string? Email { get; private set; }

    public string? Phone { get; private set; }

    public string? Address { get; private set; }

    public DateTimeOffset CreatedAt { get; private set; }

    public DateTimeOffset UpdatedAt { get; private set; }
}