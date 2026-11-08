using Microsoft.EntityFrameworkCore;

namespace Prestamax.Infrastructure.Persistence;

/// <summary>
/// Contexto de persistencia de la aplicación.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}