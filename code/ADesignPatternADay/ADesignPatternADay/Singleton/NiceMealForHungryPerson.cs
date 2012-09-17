using ADesignPatternADay.Singleton;

namespace ADesignPatternADay.Tests.Singleton
{
    public class NiceMealForHungryPerson
    {
        public Girlfriend Cook
        {
            get { return Girlfriend.Instance; }
        }
    }
}