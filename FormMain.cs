using System.Text;

namespace WeatherParserHttpGet
{
    public partial class FormMain : Form
    {
        public static string selectedCity;
        public static List<string> selectedCityList = new List<string>();
        private static SaveFileDialog saveFileDialog = new SaveFileDialog();

        public FormMain()
        {
            InitializeComponent();
            Program.regions.PrintRegions(RegionsParser.ParseRegions(), listBoxRegions);
        }

        private async void buttonGetWeather_Click(object sender, EventArgs e)
        {
            buttonGetWeather.Enabled = false;
            richTextBoxWeather.Clear();
            selectedCityList = checkedListBoxCities.CheckedItems.Cast<string>().ToList();
            progressBar.Maximum = selectedCityList.Count();

            for (int i = 0; i < selectedCityList.Count(); i++)
            {
                var weather = await Program.weatherResponse.GetWeatherAsync(selectedCityList[i]);
                Program.weatherResponse.DisplayWeather(weather, richTextBoxWeather, selectedCityList[i]);
                progressBar.Value = i + 1;
                labelDownloadStatus.Text = $"Стостояние загрузки {(int)Math.Round((double)(100 * (i + 1)) / selectedCityList.Count())}%";
            }
        }

        private void listBoxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegion = listBoxRegions.SelectedItem.ToString();
            CitiesParser.listOfCities.Clear();
            CitiesParser.listOfCities = CitiesParser.ParseCities(RegionsParser.GetRegionUrl(selectedRegion));
            Program.cities.PrintCities(CitiesParser.listOfCities, checkedListBoxCities);
        }

        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Как пользоваться программой:\n" +
                "1) Выберите регион\n" +
                "2) Выберите один или несколько городов\n" +
                "3) Нажмите кнопку [Узнать погоду]\n" +
                "4) При необходимости сохраните данные в файл\n");
        }

        private void checkedListBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGetWeather.Enabled = true;

            if (Convert.ToInt32(checkedListBoxCities.CheckedItems.Count.ToString()) < 1)
                buttonGetWeather.Enabled = false;
        }
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            FileSaver.SaveFile(saveFileDialog, richTextBoxWeather);
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа: Weather Parser HTTP GET v 1.0 (с)" +
                "\nРазработчик: Айдар Салахов" +
                "\nКазань, 2022\n" +
                "\nПарсинг погоды производится с сайта: https://goweather.herokuapp.com/weather/" +
                "\nПарсинг городов производится с сайта: https://world-weather.ru/pogoda/russia/");
        }
    }
}