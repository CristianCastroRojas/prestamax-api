namespace Prestamax.Application.Tenant.Modules.GetModules;

/// <summary>
/// Representa la respuesta con la información de un módulo.
/// </summary>
public sealed record GetModulesResponse(
    int IdModule,
    string Code,
    string Name,
    string? Icon,
    bool IsActive,
    DateTimeOffset UpdatedAt);