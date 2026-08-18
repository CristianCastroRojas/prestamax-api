namespace Prestamax.Application.Configuration.Modules.GetModules;

/// <summary>
/// Representa la respuesta con la información de un módulo.
/// </summary>
public sealed record GetModulesResponse(
    long IdModule,
    long? IdParentModule,
    string Code,
    string Name,
    string? Description,
    int DisplayOrder);