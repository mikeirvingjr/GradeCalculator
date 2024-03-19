namespace GradeCalculator.Core.Entities;

public class SchoolYear : EntityBase<int>
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public IList<School> Schools { get; set; } = new List<School>();
}