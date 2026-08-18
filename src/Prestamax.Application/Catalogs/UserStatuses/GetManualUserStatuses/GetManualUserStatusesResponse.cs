namespace Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;

/// <summary>
/// Representa la respuesta de un estado de usuario seleccionable manualmente.
/// </summary>
public sealed record GetManualUserStatusesResponse(
    long IdUserStatus,
    string Code,
    string Name);