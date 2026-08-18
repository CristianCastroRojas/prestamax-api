using Microsoft.EntityFrameworkCore;

namespace Prestamax.Infrastructure.Persistence;

/// <summary>
/// Representa el contexto de persistencia de la aplicación.
/// </summary>
public sealed class AppDbContext(
    DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}