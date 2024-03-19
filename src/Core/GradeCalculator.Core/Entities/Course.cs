namespace GradeCalculator.Core.Entities;

public class Course : EntityBase<int>
{
    public string? CourseNumber { get; set; } = string.Empty;

    public string? Name { get; set; } = string.Empty;

    public string? Instructor { get; set; } = string.Empty;

    public IList<Grade> Grades { get; set; } = new List<Grade>();

    public Grade? FinalGrade { get; set; }
}