namespace ADesignPatternADay.Singleton
{
    public class Girlfriend
    {
        private static Girlfriend _instance;
        private static string _status;

        public static void SetStatus(string status)
        {
            _status = status;
        }

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
