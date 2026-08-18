namespace Prestamax.Domain.Configuration;

/// <summary>
/// Representa una acción disponible dentro de un módulo.
/// </summary>
public sealed class ModuleAction
{
    public long IdModuleAction { get; private set; }

    public long IdModule { get; private set; }

    public string Code { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;

    public string? Description { get; private set; }
}