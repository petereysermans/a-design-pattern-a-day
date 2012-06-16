using ADesignPatternADay.Decorator;
using ADesignPatternADay.Decorator.Decorators;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Decorator.Decorators
{
    [Subject("Measuring the speed of a running handicapped dog")]
    public class When_measuring_the_speed_of_a_running_handicapped_dog
    {
        Establish context = () =>
        {
            _classUnderTest = new HandicappedDecorator(new Dog());
        };

        Because of = () =>
            _measuredSpeed = _classUnderTest.Run();

        It should_have_a_third_of_the_speed_of_a_normal_running_dog = () =>
        {
            var normalSpeed = new Dog().Run();
            _measuredSpeed.ShouldEqual(normalSpeed/3);
        };

        private static HandicappedDecorator _classUnderTest;
        private static int _measuredSpeed;
    }
}
