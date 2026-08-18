using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prestamax.Domain.Catalogs.DocumentTypes;

namespace Prestamax.Infrastructure.Catalogs.DocumentTypes;

/// <summary>
/// Configura la entidad de tipo de documento para Entity Framework Core.
/// </summary>
public sealed class DocumentTypeConfiguration
    : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.ToTable("CAT_DOCUMENT_TYPE");

        builder.HasKey(x => x.IdDocumentType);

        builder.Property(x => x.IdDocumentType)
            .HasColumnName("ID_DOCUMENT_TYPE")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Code)
            .HasColumnName("CODE")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("NAME")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Regex)
            .HasColumnName("REGEX")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(x => x.Code)
            .IsUnique()
            .HasDatabaseName("UQ_CAT_DOCUMENT_TYPE_CODE");

        builder.HasIndex(x => x.Name)
            .IsUnique()
            .HasDatabaseName("UQ_CAT_DOCUMENT_TYPE_NAME");
    }
}