using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Configuration;

namespace Prestamax.Infrastructure.Configuration.Modules;

/// <summary>
/// Configura la entidad de acción de módulo para Entity Framework Core.
/// </summary>
public sealed class ModuleActionConfiguration
    : IEntityTypeConfiguration<ModuleAction>
{
    public void Configure(EntityTypeBuilder<ModuleAction> builder)
    {
        builder.ToTable("CFG_MODULE_ACTION");

        builder.HasKey(x => x.IdModuleAction);

        builder.Property(x => x.IdModuleAction)
            .HasColumnName("ID_MODULE_ACTION")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdModule)
            .HasColumnName("ID_MODULE")
            .IsRequired();

        builder.Property(x => x.Code)
            .HasColumnName("CODE")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("NAME")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("DESCRIPTION")
            .HasMaxLength(255);

        builder.HasIndex(x => new
        {
            x.IdModule,
            x.Code
        })
            .IsUnique()
            .HasDatabaseName("UQ_CFG_MODULE_ACTION_MODULE_CODE");
    }
}