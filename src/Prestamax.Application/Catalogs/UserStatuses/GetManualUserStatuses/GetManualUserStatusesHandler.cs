namespace Prestamax.Application.Catalogs.UserStatuses.GetManualUserStatuses;

/// <summary>
/// Obtiene los estados de usuario permitidos para selección manual.
/// </summary>
public sealed class GetManualUserStatusesHandler(
    IUserStatusRepository repository)
{
    public async Task<IReadOnlyList<GetManualUserStatusesResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var userStatuses = await repository.GetManualSelectionAsync(
            cancellationToken);

        return [.. userStatuses
            .Select(userStatus => new GetManualUserStatusesResponse(
                userStatus.IdUserStatus,
                userStatus.Code,
                userStatus.Name))];
    }
}