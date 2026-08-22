namespace Prestamax.Application.Configuration.SystemVersions.GetCurrentSystemVersion;

/// <summary>
/// Representa la respuesta con la información de una versión del sistema.
/// </summary>
public sealed record GetCurrentSystemVersionResponse(
    int IdSystemVersion,
    string? Version,
    DateTimeOffset UpdatedAt,
    bool IsCurrent,
    DateTimeOffset ReleasedAt);