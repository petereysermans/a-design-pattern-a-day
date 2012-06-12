namespace ADesignPatternADay.Decorator
{
    public abstract class AnimalDecorator : Animal
    {
        protected Animal Animal;

        protected AnimalDecorator(Animal animal)
        {
            Animal = animal;
        }

        public override int Run()
        {
            return Animal.Run(); 
        }
    }
}
