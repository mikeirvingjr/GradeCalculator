namespace GradeCalculator.Core.Entities;

public class School : EntityBase<int>
{
    public string? Name { get; set; } = string.Empty;

    public Address? Address { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public IList<Semester> Semesters { get; set; } = new List<Semester>();

    public decimal? CulmulativeGPA { get; set; }
}