namespace Prestamax.Application.Tenant.BusinessDates.GetBusinessDate;

/// <summary>
/// Representa la respuesta con la fecha de negocio de una organización.
/// </summary>
public sealed record GetBusinessDateResponse(
    int IdBusinessDate,
    int IdOrganization,
    DateOnly BusinessDate,
    DateTimeOffset UpdatedAt);