namespace ADesignPatternADay.Singleton
{
    public class Girlfriend
    {
        private static Girlfriend _instance;

        public static Girlfriend Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Girlfriend();
                }

                return _instance;
            }
        }
    }
}
