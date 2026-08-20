namespace Prestamax.Domain.Organizations.BusinessDates;

/// <summary>
/// Representa la fecha de negocio vigente de una organización.
/// </summary>
public sealed class BusinessDate
{
    public int IdBusinessDate { get; private set; }

    public int IdOrganization { get; private set; }

    public DateOnly Date { get; private set; }

    public DateTimeOffset UpdatedAt { get; private set; }
}