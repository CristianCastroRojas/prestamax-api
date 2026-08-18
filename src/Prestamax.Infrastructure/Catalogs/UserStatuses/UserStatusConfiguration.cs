using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Catalogs.UserStatuses;

namespace Prestamax.Infrastructure.Catalogs.UserStatuses;

/// <summary>
/// Configura la entidad de estado de usuario para Entity Framework Core.
/// </summary>
public sealed class UserStatusConfiguration
    : IEntityTypeConfiguration<UserStatus>
{
    public void Configure(EntityTypeBuilder<UserStatus> builder)
    {
        builder.ToTable("CAT_USER_STATUS");

        builder.HasKey(x => x.IdUserStatus);

        builder.Property(x => x.IdUserStatus)
            .HasColumnName("ID_USER_STATUS")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Code)
            .HasColumnName("CODE")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("NAME")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.AllowManualSelection)
            .HasColumnName("ALLOW_MANUAL_SELECTION")
            .HasDefaultValue(false)
            .IsRequired();

        builder.HasIndex(x => x.Code)
            .IsUnique()
            .HasDatabaseName("UQ_CAT_USER_STATUS_CODE");

        builder.HasIndex(x => x.Name)
            .IsUnique()
            .HasDatabaseName("UQ_CAT_USER_STATUS_NAME");
    }
}