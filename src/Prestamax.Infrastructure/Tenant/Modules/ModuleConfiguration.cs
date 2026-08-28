using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Tenant.Modules;
using Prestamax.Domain.Tenant.Organizations;

namespace Prestamax.Infrastructure.Tenant.Modules;

/// <summary>
/// Configura la entidad de módulo para Entity Framework Core.
/// </summary>
public sealed class ModuleConfiguration
    : IEntityTypeConfiguration<Module>
{
    public void Configure(EntityTypeBuilder<Module> builder)
    {
        builder.ToTable("TEN_MODULE");

        builder.HasKey(x => x.IdModule)
            .HasName("PK_TEN_MODULE");

        builder.Property(x => x.IdModule)
            .HasColumnName("ID_MODULE")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdOrganization)
            .HasColumnName("ID_ORGANIZATION")
            .IsRequired();

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

        builder.Property(x => x.Route)
            .HasColumnName("ROUTE")
            .HasMaxLength(300);

        builder.Property(x => x.Icon)
            .HasColumnName("ICON")
            .HasMaxLength(100);

        builder.Property(x => x.DisplayOrder)
            .HasColumnName("DISPLAY_ORDER")
            .HasDefaultValue(0)
            .IsRequired();

        builder.Property(x => x.IsActive)
            .HasColumnName("IS_ACTIVE")
            .HasDefaultValue(true)
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasColumnName("CREATED_AT")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("UPDATED_AT")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        // --------------------------------------------------------
        // UNIQUE: una organización no puede repetir el CODE
        // --------------------------------------------------------
        builder.HasIndex(x => new
        {
            x.IdOrganization,
            x.Code
        })
        .IsUnique()
        .HasDatabaseName("UQ_TEN_MODULE_ORGANIZATION_CODE");

        // --------------------------------------------------------
        // UNIQUE: necesario para la FK compuesta del padre
        // --------------------------------------------------------
        builder.HasIndex(x => new
        {
            x.IdOrganization,
            x.IdModule
        })
        .IsUnique()
        .HasDatabaseName("UQ_TEN_MODULE_ORGANIZATION_ID");

        // --------------------------------------------------------
        // FK: módulo pertenece a una organización
        // --------------------------------------------------------
        builder.HasOne<Organization>()
            .WithMany()
            .HasForeignKey(x => x.IdOrganization)
            .HasConstraintName("FK_TEN_MODULE_ORGANIZATION")
            .OnDelete(DeleteBehavior.Restrict);

        // --------------------------------------------------------
        // FK COMPUESTA:
        //
        // (ID_ORGANIZATION, ID_PARENT_MODULE)
        //        ↓
        // (ID_ORGANIZATION, ID_MODULE)
        //
        // Garantiza que el módulo padre pertenezca a la
        // misma organización que el módulo hijo.
        // --------------------------------------------------------
        builder.HasOne<Module>()
            .WithMany()
            .HasForeignKey(
                x => new
                {
                    x.IdOrganization,
                    x.IdParentModule
                })
            .HasPrincipalKey(
                x => new
                {
                    x.IdOrganization,
                    x.IdModule
                })
            .HasConstraintName("FK_TEN_MODULE_PARENT")
            .OnDelete(DeleteBehavior.Restrict);
    }
}