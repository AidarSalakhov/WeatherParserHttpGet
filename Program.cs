namespace WeatherParserHttpGet
{
    internal static class Program
    {
        public static WeatherResponse weatherResponse;
        public static Regions regions;
        public static Cities cities;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }

        static void Init()
        {
            weatherResponse = new WeatherResponse();
            regions = new Regions();
            cities = new Cities();
        }
    }
}