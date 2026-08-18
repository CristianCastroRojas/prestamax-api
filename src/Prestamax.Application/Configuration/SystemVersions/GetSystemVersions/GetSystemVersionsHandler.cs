namespace Prestamax.Application.Configuration.SystemVersions.GetSystemVersions;

/// <summary>
/// Obtiene todas las versiones del sistema.
/// </summary>
public sealed class GetSystemVersionsHandler(
    ISystemVersionRepository repository)
{
    public async Task<IReadOnlyList<GetSystemVersionsResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var systemVersions = await repository.GetAllAsync(
            cancellationToken);

        return [.. systemVersions
            .Select(systemVersion => new GetSystemVersionsResponse(
                systemVersion.IdSystemVersion,
                systemVersion.Version,
                systemVersion.UpdatedAt))];
    }
}