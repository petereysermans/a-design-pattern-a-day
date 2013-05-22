namespace ADesignPatternADay.Singleton
{
    public class NiceMealForHungryGuy
    {
        public Girlfriend Cook
        {
            get { return Girlfriend.Instance; }
        }
    }
}