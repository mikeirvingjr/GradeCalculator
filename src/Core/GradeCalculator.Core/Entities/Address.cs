namespace GradeCalculator.Core.Entities;

public class Address : EntityBase<int>
{
    public string? Street { get; set; } = string.Empty;

    public string? Street2 { get; set; } = string.Empty;

    public string? City { get; set; } = string.Empty;

    public string? StateProvince { get; set; } = string.Empty;

    public string? PostalCode { get; set; } = string.Empty;
}