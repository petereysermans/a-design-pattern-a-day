using ADesignPatternADay.Singleton;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Singleton
{
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
