namespace Prestamax.Application.Common.Errors;

/// <summary>
/// Representa un error de aplicación.
/// </summary>
public sealed record ApplicationError(
    string Code,
    string Message);