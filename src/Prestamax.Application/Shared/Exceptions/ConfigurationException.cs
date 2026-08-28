using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Common.Exceptions;

/// <summary>
/// Representa una inconsistencia en la configuración del sistema.
/// </summary>
public sealed class ConfigurationException(
    ApplicationError error) : Exception(error.Message)
{
    public string Code { get; } = error.Code;
}