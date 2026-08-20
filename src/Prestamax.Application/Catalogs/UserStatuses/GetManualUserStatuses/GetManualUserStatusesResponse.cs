namespace Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;

/// <summary>
/// Representa la respuesta de un estado de usuario seleccionable manualmente.
/// </summary>
public sealed record GetManualUserStatusesResponse(
    int IdUserStatus,
    string Code,
    string Name);