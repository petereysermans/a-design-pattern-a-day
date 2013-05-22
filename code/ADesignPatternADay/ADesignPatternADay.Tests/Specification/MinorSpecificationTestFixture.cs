using ADesignPatternADay.Specification;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Specification
{
    [Subject("While checking if a person is a minor")]
    public class When_the_person_is_18_or_older : While_checking_if_a_person_is_a_minor
    {
        Establish context = () =>
            _person = new Person(18);

        It should_not_be_a_minor = () =>
            _result.ShouldBeFalse();
    }

    [Subject("While checking if a person is a minor")]
    public class When_the_person_is_younger_than_18 : While_checking_if_a_person_is_a_minor
    {
        Establish context = () =>
                {
                    _person = new Person(17);
                };
            
        It should_be_a_minor = () =>
            _result.ShouldBeTrue();
    }

    public class While_checking_if_a_person_is_a_minor
    {
        Establish context = () =>
            _minorSpecification = new MinorSpecification();

        Because of = () =>
            _result = _minorSpecification.IsSatisfied(_person);

        protected static Person _person;
        protected static MinorSpecification _minorSpecification;
        protected static bool _result;
        
    }
}
