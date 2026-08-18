namespace Prestamax.Application.Catalogs.UserStatuses.GetUserStatuses;

/// <summary>
/// Representa la respuesta con la información de un estado de usuario.
/// </summary>
public sealed record GetUserStatusesResponse(
    long IdUserStatus,
    string Code,
    string Name,
    bool AllowManualSelection);