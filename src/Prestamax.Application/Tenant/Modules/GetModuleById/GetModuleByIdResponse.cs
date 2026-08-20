namespace Prestamax.Application.Tenant.Modules.GetModuleById;

/// <summary>
/// Representa la respuesta para la consulta de un módulo específico.
/// </summary>
public sealed record GetModuleByIdResponse(
    int IdModule,
    int IdOrganization,
    int? IdParentModule,
    string Code,
    string Name,
    string? Route,
    string? Icon,
    int DisplayOrder,
    bool IsActive,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt
);