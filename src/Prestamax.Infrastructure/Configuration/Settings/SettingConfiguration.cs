using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Configuration.Settings;
using Prestamax.Domain.Tenant.Organizations;

namespace Prestamax.Infrastructure.Configuration.Settings;

/// <summary>
/// Configura la entidad de configuración para Entity Framework Core.
/// </summary>
public sealed class SettingConfiguration
    : IEntityTypeConfiguration<Setting>
{
    public void Configure(EntityTypeBuilder<Setting> builder)
    {
        builder.ToTable("CFG_SETTING");

        builder.HasKey(x => x.IdSetting)
            .HasName("PK_CFG_SETTING");

        builder.Property(x => x.IdSetting)
            .HasColumnName("ID_SETTING")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdOrganization)
            .HasColumnName("ID_ORGANIZATION")
            .IsRequired();

        builder.Property(x => x.SettingKey)
            .HasColumnName("SETTING_KEY")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.SettingValue)
            .HasColumnName("SETTING_VALUE")
            .IsRequired();

        builder.Property(x => x.Description)
            .HasColumnName("DESCRIPTION")
            .HasMaxLength(255);

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("UPDATED_AT")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.HasIndex(x => new
        {
            x.IdOrganization,
            x.SettingKey
        })
            .IsUnique()
            .HasDatabaseName("UQ_CFG_SETTING_ORGANIZATION_KEY");

        builder.HasOne<Organization>()
            .WithMany()
            .HasForeignKey(x => x.IdOrganization)
            .HasConstraintName("FK_CFG_SETTING_ORGANIZATION")
            .OnDelete(DeleteBehavior.Restrict);
    }
}