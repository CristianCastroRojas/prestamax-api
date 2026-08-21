using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Common.Exceptions;

/// <summary>
/// Representa un recurso que no fue encontrado.
/// </summary>
public sealed class NotFoundException(
    ApplicationError error) : Exception(error.Message)
{
    public string Code { get; } = error.Code;
}