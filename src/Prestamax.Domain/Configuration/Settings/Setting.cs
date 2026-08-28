namespace Prestamax.Domain.Configuration.Settings;

/// <summary>
/// Representa una configuración parametrizable de una organización.
/// </summary>
public sealed class Setting
{
    public int IdSetting { get; private set; }

    public int IdOrganization { get; private set; }

    public string SettingKey { get; private set; } = string.Empty;

    public string SettingValue { get; private set; } = string.Empty;

    public string? Description { get; private set; }

    public DateTimeOffset UpdatedAt { get; private set; }
}