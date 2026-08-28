using Prestamax.Application.Common.Exceptions;
using Prestamax.Application.Configuration.SystemVersions.Errors;

namespace Prestamax.Application.Configuration.SystemVersions.GetCurrentSystemVersion;

/// <summary>
/// Obtiene la versión vigente del sistema.
/// </summary>
public sealed class GetCurrentSystemVersionHandler(
    ISystemVersionRepository repository)
{
    public async Task<GetCurrentSystemVersionResponse> HandleAsync(
        CancellationToken cancellationToken)
    {
        var systemVersion = await repository.GetCurrentAsync(
            cancellationToken);

        return systemVersion is null
            ? throw new ConfigurationException(
                SystemVersionErrors.CurrentVersionNotConfigured)
            : new GetCurrentSystemVersionResponse(
                systemVersion.IdSystemVersion,
                systemVersion.Version,
                systemVersion.UpdatedAt,
                systemVersion.IsCurrent,
                systemVersion.ReleasedAt);
    }
}