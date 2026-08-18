using Microsoft.Extensions.DependencyInjection;

namespace Prestamax.Infrastructure.Persistence;

/// <summary>
/// Verifica la conexión con la base de datos.
/// </summary>
public static class DatabaseConnectionChecker
{
    public static async Task CheckDatabaseConnectionAsync(
        this IServiceProvider services)
    {
        using var scope = services.CreateScope();

        var dbContext = scope.ServiceProvider
            .GetRequiredService<AppDbContext>();

        try
        {
            var canConnect =
                await dbContext.Database.CanConnectAsync();

            if (!canConnect)
            {
                throw new InvalidOperationException(
                    "No fue posible establecer conexión con la base de datos.");
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(
                "Ocurrió un error al establecer conexión con la base de datos.",
                ex);
        }
    }
}