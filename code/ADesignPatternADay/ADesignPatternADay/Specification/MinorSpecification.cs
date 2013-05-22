using ADesignPatternADay.Specification.Interfaces;

namespace ADesignPatternADay.Specification
{
    public class MinorSpecification : ISpecification
    {
        public bool IsSatisfied(object candidate)
        {
            var person = (Person) candidate;
            return person.Age < 18;
        }
    }
}