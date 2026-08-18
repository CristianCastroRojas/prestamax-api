namespace Prestamax.Application.Configuration.SystemVersions.GetSystemVersions;

/// <summary>
/// Representa la respuesta con la información de una versión del sistema.
/// </summary>
public sealed record GetSystemVersionsResponse(
    long IdSystemVersion,
    string Version,
    DateTimeOffset UpdatedAt);