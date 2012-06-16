namespace ADesignPatternADay.Decorator.Decorators
{
    public class HandicappedDecorator : AnimalDecorator
    {
        public HandicappedDecorator(Animal animal)
            : base(animal)
        {
        }

        public override int Run()
        {
            return base.Run() / 3;
        }
    }
}
