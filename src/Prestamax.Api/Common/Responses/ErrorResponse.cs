namespace Prestamax.Api.Common.Responses;

/// <summary>
/// Representa la respuesta estándar de error de la API.
/// </summary>
public sealed record ErrorResponse(
    string Code,
    string Message,
    string TraceId);