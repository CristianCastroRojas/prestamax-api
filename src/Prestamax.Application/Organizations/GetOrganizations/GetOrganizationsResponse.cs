namespace Prestamax.Application.Organizations.GetOrganizations;

/// <summary>
/// Representa la respuesta con la información de una organización.
/// </summary>
public sealed record GetOrganizationsResponse(
    long IdOrganization,
    string Name,
    string DocumentNumber,
    string? Email,
    string? Phone,
    string? Address,
    DateTimeOffset? UpdatedAt);