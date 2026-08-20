using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Tenant.Organizations;

namespace Prestamax.Infrastructure.Tenant.Organizations;

/// <summary>
/// Configura la entidad de organización para Entity Framework Core.
/// </summary>
public sealed class OrganizationConfiguration
    : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.ToTable("TEN_ORGANIZATION");

        builder.HasKey(x => x.IdOrganization);

        builder.Property(x => x.IdOrganization)
            .HasColumnName("ID_ORGANIZATION")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.LegalName)
            .HasColumnName("LEGAL_NAME")
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.CommercialName)
            .HasColumnName("COMMERCIAL_NAME")
            .HasMaxLength(200);

        builder.Property(x => x.IdDocumentType)
            .HasColumnName("ID_DOCUMENT_TYPE")
            .IsRequired();

        builder.Property(x => x.DocumentNumber)
            .HasColumnName("DOCUMENT_NUMBER")
            .HasMaxLength(30)
            .IsRequired();

        builder.HasIndex(x => new
        {
            x.IdDocumentType,
            x.DocumentNumber
        })
            .IsUnique()
            .HasDatabaseName("UQ_TEN_ORGANIZATION_DOCUMENT");

        builder.Property(x => x.Email)
            .HasColumnName("EMAIL")
            .HasMaxLength(255);

        builder.Property(x => x.Phone)
            .HasColumnName("PHONE")
            .HasMaxLength(30);

        builder.Property(x => x.Address)
            .HasColumnName("ADDRESS")
            .HasMaxLength(300);

        builder.Property(x => x.CreatedAt)
            .HasColumnName("CREATED_AT")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .HasColumnName("UPDATED_AT")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .IsRequired();

        builder.HasOne<Domain.Catalogs.DocumentTypes.DocumentType>()
            .WithMany()
            .HasForeignKey(x => x.IdDocumentType)
            .HasConstraintName("FK_TEN_ORGANIZATION_DOCUMENT_TYPE")
            .OnDelete(DeleteBehavior.Restrict);
    }
}