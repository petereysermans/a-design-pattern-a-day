using ADesignPatternADay.Singleton;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Singleton
{
    [Subject("Getting the person that cooks the nice meal for the hungry guy")]
    public class When_getting_the_person_that_cooks_the_nice_meal_for_the_hungry_guy
    {
        Establish context = () =>
            _niceMeal = new NiceMealForHungryPerson();

        Because of = () =>
            {
                _girlFriend = Girlfriend.Instance;
                _cook = _niceMeal.Cook;
            };

        private static NiceMealForHungryPerson _niceMeal;
        private static Girlfriend _girlFriend;
        private static Girlfriend _cook;

        It should_return_the_same_person_as_our_girlfriend = () =>
            _girlFriend.GetHashCode().ShouldEqual(_cook.GetHashCode());
    }
}