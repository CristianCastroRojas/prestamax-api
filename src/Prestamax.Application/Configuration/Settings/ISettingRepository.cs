namespace Prestamax.Application.Configuration.Settings;

/// <summary>
/// Define el contrato para el acceso a las configuraciones.
/// </summary>
public interface ISettingRepository
{
    /// <summary>
    /// Obtiene el valor de una configuración para una organización.
    /// </summary>
    Task<string?> GetValueAsync(
        int organizationId,
        string settingKey,
        CancellationToken cancellationToken);
}