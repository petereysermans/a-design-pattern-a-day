namespace ADesignPatternADay.Decorator.Decorators
{
    public class BionicLegsDecorator : AnimalDecorator
    {
        public BionicLegsDecorator(Animal animal) : base(animal)
        {
        }

        public override int Run()
        {
            return base.Run() * 2;
        }
    }
}
