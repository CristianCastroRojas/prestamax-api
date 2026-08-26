using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Tenant.Modules.Errors;

/// <summary>
/// Define los errores relacionados con los modulos.
/// </summary>
public static class ModuleErrors
{
    public static readonly ApplicationError NotFound = new(
        "MODULE_NOT_FOUND",
        "No se encontró el módulo solicitado.");
}
