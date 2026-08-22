using Prestamax.Application.Common.Errors;

namespace Prestamax.Application.Tenant.BusinessDates.Errors;

/// <summary>
/// Define los errores relacionados con las fechas de negocio.
/// </summary>
public static class BusinessDateErrors
{
    public static readonly ApplicationError NotFound = new(
        "BUSINESS_DATE_NOT_FOUND",
        "No se encontró la fecha de negocio configurada para la organización solicitada.");
}