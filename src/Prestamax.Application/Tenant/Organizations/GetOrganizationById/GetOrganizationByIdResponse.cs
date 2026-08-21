namespace Prestamax.Application.Tenant.Organizations.GetOrganizationById;

/// <summary>
/// Representa la respuesta con la información de una organización.
/// </summary>
public sealed record GetOrganizationByIdResponse(
    int IdOrganization,
    string LegalName,
    string? CommercialName,
    int IdDocumentType,
    string DocumentNumber,
    string? Email,
    string? Phone,
    string? Address,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt);