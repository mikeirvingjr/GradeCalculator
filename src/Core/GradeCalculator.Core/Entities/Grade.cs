namespace GradeCalculator.Core.Entities;

public class Grade : EntityBase<int>
{
    public string? Assignment { get; set; } = string.Empty;

    public string? Description { get; set; } = string.Empty;

    public decimal OverallValue { get; set; }

    public decimal Score { get; set; }

    public decimal? MaxScore { get; set; }

    public decimal Result => (MaxScore > 0M) ? Score / MaxScore.GetValueOrDefault() * 100M : Score;

    public string? Letter { get; set; } = string.Empty;
}