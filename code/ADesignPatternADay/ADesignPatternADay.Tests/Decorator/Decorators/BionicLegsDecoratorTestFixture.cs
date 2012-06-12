using ADesignPatternADay.Decorator;
using ADesignPatternADay.Decorator.Decorators;
using Machine.Specifications;

namespace ADesignPatternADay.Tests.Decorator.Decorators
{
    [Subject("Measuring the speed of a running dog with bionic legs")]
    public class When_measuring_the_speed_of_a_running_dog_with_bionic_legs
    {
        Establish context = () =>
            _classUnderTest = new BionicLegsDecorator(new Dog());

        Because of = () => 
            _measuredSpeed = _classUnderTest.Run();

        It should_have_double_the_speed_of_a_normal_dog = () =>
        {
            var normalSpeed = new Dog().Run();
            _measuredSpeed.ShouldEqual(normalSpeed * 2);
        };

        private static BionicLegsDecorator _classUnderTest;
        private static int _measuredSpeed;
    }
}
