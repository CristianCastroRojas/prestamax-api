using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Configuration;

namespace Prestamax.Infrastructure.Configuration.Modules;

/// <summary>
/// Configura la entidad de módulo para Entity Framework Core.
/// </summary>
public sealed class ModuleConfiguration
    : IEntityTypeConfiguration<Module>
{
    public void Configure(EntityTypeBuilder<Module> builder)
    {
        builder.ToTable("CFG_MODULE");

        builder.HasKey(x => x.IdModule);

        builder.Property(x => x.IdModule)
            .HasColumnName("ID_MODULE")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdParentModule)
            .HasColumnName("ID_PARENT_MODULE");

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
            .HasMaxLength(500);

        builder.Property(x => x.DisplayOrder)
            .HasColumnName("DISPLAY_ORDER")
            .IsRequired();

        builder.HasIndex(x => x.Code)
            .IsUnique()
            .HasDatabaseName("UQ_CFG_MODULE_CODE");

        builder.HasOne<Module>()
            .WithMany()
            .HasForeignKey(x => x.IdParentModule)
            .HasConstraintName("FK_CFG_MODULE_PARENT");
    }
}