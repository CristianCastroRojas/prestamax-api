using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Configuration.SystemVersions.Errors;

/// <summary>
/// Define los errores relacionados con las versiones del sistema.
/// </summary>
public static class SystemVersionErrors
{
    public static readonly ApplicationError NotFound = new(
        "SYSTEM_VERSION_NOT_FOUND",
        "No se encontró una versión vigente del sistema.");
}
