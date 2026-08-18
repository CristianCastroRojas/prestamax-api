namespace Prestamax.Domain.Organizations;

/// <summary>
/// Representa una organización que utiliza el sistema.
/// </summary>
public sealed class Organization
{
    public long IdOrganization { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string DocumentNumber { get; private set; } = string.Empty;

    public string? Email { get; private set; }

    public string? Phone { get; private set; }

    public string? Address { get; private set; }

    public DateTimeOffset? UpdatedAt { get; private set; }
}