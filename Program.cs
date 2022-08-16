namespace WeatherParserHttpGet
{
    internal static class Program
    {
        public static WeatherParser weatherResponse;
        public static RegionsParser regions;
        public static CitiesParser cities;


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
            weatherResponse = new WeatherParser();
            regions = new RegionsParser();
            cities = new CitiesParser();
        }
    }
}