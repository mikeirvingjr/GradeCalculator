namespace GradeCalculator.Core.Entities;

public class Semester : EntityBase<int>
{
    public string? Name { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public IList<Course> Courses { get; set; } = new List<Course>();

    public Grade? FinalGrade { get; set; }

    public decimal GPA { get; set; }
}