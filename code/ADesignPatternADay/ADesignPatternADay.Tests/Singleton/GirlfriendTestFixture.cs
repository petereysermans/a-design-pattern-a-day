using ADesignPatternADay.Singleton;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Singleton
{
    [Subject("Getting the girlfriend and the house is dirty")]
    public class When_getting_the_girlfried_and_the_house_is_dirty
    {
        //It should_return_
    }

    [Subject("Getting the girlfriend an we are hungry")]
    public class When_getting_the_girlfriend_and_we_are_hungry
    {
        Establish context = () => 
            Girlfriend.SetStatus("We are hungry");

        Because of = () =>
            _girlFriend = Girlfriend.Instance;

        It should_return_a_cooking_girlfriend = () =>
            _girlFriend.ShouldBeOfType(typeof(CookingGirlfriend));

        It should_should_return_the_same_cooking_girlfriend = () =>
            _girlFriend.GetHashCode().ShouldEqual(CookingGirlfriend.Instance.GetHashCode());

        private static Girlfriend _girlFriend;
    }

    [Subject("Getting the girlfriend")]
    public class When_getting_girlfriend
    {
        Because of = () =>
            _hashCode = Girlfriend.Instance.GetHashCode();

        It should_always_return_the_same_girlfriend = () =>
        {
            var hashCode = Girlfriend.Instance.GetHashCode();
            _hashCode.ShouldEqual(hashCode);
        };

        private static int _hashCode;
    }
}
