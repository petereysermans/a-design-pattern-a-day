using ADesignPatternADay.Decorator;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Decorator
{
    [Subject("Measuring the speed of a running dog")]
    public class When_measuring_the_speed_of_a_running_dog
    {
        Establish context = () =>
        {
            _classUnderTest = new Dog();
        };

        Because of = () =>
            _measuredSpeed = _classUnderTest.Run();

        It should_have_a_speed_of_25_miles_per_hour = () =>
            _measuredSpeed.ShouldEqual(25);

        private static Dog _classUnderTest;
        private static int _measuredSpeed;
    }
}
