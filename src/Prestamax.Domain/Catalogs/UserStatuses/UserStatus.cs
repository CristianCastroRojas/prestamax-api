namespace Prestamax.Domain.Catalogs.UserStatuses;

/// <summary>
/// Representa un estado de usuario.
/// </summary>
public sealed class UserStatus
{
    public int IdUserStatus { get; private set; }

    public string Code { get; private set; } = string.Empty;

    public string Name { get; private set; } = string.Empty;

    public bool AllowManualSelection { get; private set; }
}