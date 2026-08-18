using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Organizations.BusinessDates;

namespace Prestamax.Infrastructure.Organizations.BusinessDates;

/// <summary>
/// Configura la entidad de fecha de negocio para Entity Framework Core.
/// </summary>
public sealed class BusinessDateConfiguration
    : IEntityTypeConfiguration<BusinessDate>
{
    public void Configure(EntityTypeBuilder<BusinessDate> builder)
    {
        builder.ToTable("TEN_BUSINESS_DATE");

        builder.HasKey(x => x.IdBusinessDate);

        builder.Property(x => x.IdBusinessDate)
            .HasColumnName("ID_BUSINESS_DATE")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.IdOrganization)
            .HasColumnName("ID_ORGANIZATION")
            .IsRequired();

        builder.HasIndex(x => x.IdOrganization)
            .IsUnique()
            .HasDatabaseName("UQ_TEN_BUSINESS_DATE_ORGANIZATION");

        builder.Property(x => x.Date)
            .HasColumnName("BUSINESS_DATE")
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("UPDATED_AT")
            .IsRequired();
    }
}