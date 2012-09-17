using ADesignPatternADay.Singleton;

namespace ADesignPatternADay.Tests.Singleton
{
    public class DirtyHouse
    {
        public Girlfriend CleaningPerson
        {
            get
            {
                return Girlfriend.Instance;
            }
        }
    }
}