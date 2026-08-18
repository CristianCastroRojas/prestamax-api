namespace Prestamax.Application.Organizations.GetBusinessDate;

/// <summary>
/// Representa la respuesta con la fecha de negocio de una organización.
/// </summary>
public sealed record GetBusinessDateResponse(
    long IdBusinessDate,
    long IdOrganization,
    DateOnly BusinessDate,
    DateTimeOffset UpdatedAt);