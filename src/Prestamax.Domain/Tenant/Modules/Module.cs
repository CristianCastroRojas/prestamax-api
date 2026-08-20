namespace Prestamax.Domain.Tenant.Modules;

/// <summary>
/// Representa un módulo de navegación de una organización.
/// </summary>
public sealed class Module
{
    public int IdModule { get; private set; }

    public int IdOrganization { get; private set; }

    public int? IdParentModule { get; private set; }

    public string Code { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;

    public string? Route { get; private set; }

    public string? Icon { get; private set; }

    public int DisplayOrder { get; private set; }

    public bool IsActive { get; private set; }

    public DateTimeOffset CreatedAt { get; private set; }

    public DateTimeOffset UpdatedAt { get; private set; }
}