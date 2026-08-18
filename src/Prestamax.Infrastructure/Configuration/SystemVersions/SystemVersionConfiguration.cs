using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Configuration;

namespace Prestamax.Infrastructure.Configuration.SystemVersions;

/// <summary>
/// Configura la entidad de versión del sistema para Entity Framework Core.
/// </summary>
public sealed class SystemVersionConfiguration
    : IEntityTypeConfiguration<SystemVersion>
{
    public void Configure(EntityTypeBuilder<SystemVersion> builder)
    {
        builder.ToTable("CFG_SYSTEM_VERSION");

        builder.HasKey(x => x.IdSystemVersion);

        builder.Property(x => x.IdSystemVersion)
            .HasColumnName("ID_SYSTEM_VERSION")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Version)
            .HasColumnName("VERSION")
            .HasMaxLength(20)
            .IsRequired();

        builder.HasIndex(x => x.Version)
            .IsUnique()
            .HasDatabaseName("UQ_CFG_SYSTEM_VERSION_VERSION");

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("UPDATED_AT")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();
    }
}