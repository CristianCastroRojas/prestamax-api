using Prestamax.Application.Catalogs.UserStatuses;

namespace Prestamax.Application.Catalogs.UserStatuses.GetUserStatuses;

/// <summary>
/// Obtiene todos los estados de usuario.
/// </summary>
public sealed class GetUserStatusesHandler(
    IUserStatusRepository repository)
{
    public async Task<IReadOnlyList<GetUserStatusesResponse>> HandleAsync(
        CancellationToken cancellationToken)
    {
        var userStatuses = await repository.GetAllAsync(
            cancellationToken);

        return [.. userStatuses
            .Select(userStatus => new GetUserStatusesResponse(
                userStatus.IdUserStatus,
                userStatus.Code,
                userStatus.Name,
                userStatus.AllowManualSelection))];
    }
}