namespace Prestamax.Domain.Organizations.BusinessDates;

/// <summary>
/// Representa la fecha de negocio vigente de una organización.
/// </summary>
public sealed class BusinessDate
{
    public long IdBusinessDate { get; private set; }

    public long IdOrganization { get; private set; }

    public DateOnly Date { get; private set; }

    public DateTimeOffset UpdatedAt { get; private set; }
}