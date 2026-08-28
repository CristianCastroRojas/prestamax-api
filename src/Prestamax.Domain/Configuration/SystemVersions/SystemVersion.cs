namespace Prestamax.Domain.Configuration.SystemVersions;

/// <summary>
/// Representa una versión del sistema.
/// </summary>
public sealed class SystemVersion
{
    public int IdSystemVersion { get; private set; }

    public string Version { get; private set; } = string.Empty;

    public DateTimeOffset UpdatedAt { get; private set; }

    public bool IsCurrent { get; private set; }

    public DateTimeOffset ReleasedAt { get; private set; }
}