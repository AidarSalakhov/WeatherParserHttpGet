namespace WeatherParserHttpGet
{
    internal static class Program
    {
        public static WeatherResponse weatherResponse;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static void Init()
        {
            weatherResponse = new WeatherResponse();
        }
    }
}