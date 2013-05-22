namespace ADesignPatternADay.Specification.Interfaces
{
    public interface ISpecification
    {
        bool IsSatisfied(object candidate);
    }
}