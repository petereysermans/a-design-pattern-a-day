namespace ADesignPatternADay.Singleton
{
    public class Girlfriend
    {
        private static readonly Girlfriend _instance = new Girlfriend();

        private Girlfriend()
        {
            
        }

        public static Girlfriend Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
