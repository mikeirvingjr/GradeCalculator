namespace GradeCalculator.Core.Entities;

public abstract class EntityBase<T>
{
    public T? Id { get; set; }
}