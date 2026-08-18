namespace Prestamax.Domain.Configuration;

/// <summary>
/// Representa una versión del sistema.
/// </summary>
public sealed class SystemVersion
{
    public long IdSystemVersion { get; private set; }

    public string Version { get; private set; } = string.Empty;

    public DateTimeOffset UpdatedAt { get; private set; }
}