using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Tenant.Organizations.Errors;

/// <summary>
/// Define los errores relacionados con las organizaciones.
/// </summary>
public static class OrganizationErrors
{
    public static readonly ApplicationError NotFound = new(
        "ORGANIZATION_NOT_FOUND",
        "No se encontró la organización solicitada.");
}