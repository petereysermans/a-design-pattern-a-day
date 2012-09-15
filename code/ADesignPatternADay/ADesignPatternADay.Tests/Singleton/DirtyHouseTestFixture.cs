using ADesignPatternADay.Singleton;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Singleton
{
    [Subject("Getting the person that cleans the dirty house")]
    public class When_getting_the_person_that_cleans_the_dirty_house
    {
        Establish context = () =>
            _dirtyHouse = new DirtyHouse();

        Because of = () =>
            {
                _girlFriend = Girlfriend.Instance;
                _personThatCleans = _dirtyHouse.CleaningPerson;
            };

        It should_return_the_same_person_as_our_girlfriend = () =>
            _girlFriend.GetHashCode().ShouldEqual(_personThatCleans.GetHashCode());
            
        private static DirtyHouse _dirtyHouse;
        private static Girlfriend _girlFriend;
        private static Girlfriend _personThatCleans;
    }
}