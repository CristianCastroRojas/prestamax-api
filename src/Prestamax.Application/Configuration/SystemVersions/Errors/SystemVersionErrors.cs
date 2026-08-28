using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Configuration.SystemVersions.Errors;

/// <summary>
/// Define los errores relacionados con la configuración de la versión del sistema.
/// </summary>
public static class SystemVersionErrors
{
    public static readonly ApplicationError CurrentVersionNotConfigured = new(
        "SYSTEM_VERSION_CURRENT_NOT_CONFIGURED",
        "La versión vigente del sistema no está configurada.");
}