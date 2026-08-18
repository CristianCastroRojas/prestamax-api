namespace Prestamax.Domain.Configuration;

/// <summary>
/// Representa un módulo de configuración del sistema.
/// </summary>
public sealed class Module
{
    public long IdModule { get; private set; }

    public long? IdParentModule { get; private set; }

    public string Code { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;

    public string? Description { get; private set; }

    public int DisplayOrder { get; private set; }
}