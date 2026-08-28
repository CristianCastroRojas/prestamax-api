using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Prestamax.Infrastructure.Persistence;

/// <summary>
/// Verifica la conexión con la base de datos durante el inicio de la aplicación.
/// </summary>
public static class DatabaseConnectionChecker
{
    private const string DatabaseConnectionError = "No fue posible establecer conexión con la base de datos.";

    public static async Task CheckDatabaseConnectionAsync(
        this IServiceProvider services)
    {
        using var scope = services.CreateScope();

        var loggerFactory = scope.ServiceProvider
            .GetRequiredService<ILoggerFactory>();

        var logger = loggerFactory.CreateLogger(
            nameof(DatabaseConnectionChecker));

        var dbContext = scope.ServiceProvider
            .GetRequiredService<AppDbContext>();

        logger.LogInformation(
            "Verificando conexión con la base de datos...");

        if (!await dbContext.Database.CanConnectAsync())
        {
            logger.LogCritical(
                "{DatabaseConnectionError} La aplicación no puede iniciar.",
                DatabaseConnectionError);

            throw new InvalidOperationException(
                DatabaseConnectionError);
        }

        logger.LogInformation(
            "Conexión con la base de datos establecida correctamente.");
    }
}