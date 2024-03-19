namespace GradeCalculator.Core.Entities;

public class GradeRange
{
    public decimal Start { get; set; }

    public decimal End { get; set; }

    public string? Letter { get; set; } = string.Empty;

    public bool Evaluate(decimal result) => result >= Start && result <= End;
}