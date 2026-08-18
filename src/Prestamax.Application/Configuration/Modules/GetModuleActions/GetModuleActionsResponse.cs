namespace Prestamax.Application.Configuration.Modules.GetModuleActions;

/// <summary>
/// Representa la respuesta con la información de una acción de módulo.
/// </summary>
public sealed record GetModuleActionsResponse(
    long IdModuleAction,
    long IdModule,
    string Code,
    string Name,
    string? Description);