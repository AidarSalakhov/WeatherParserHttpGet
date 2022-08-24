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
            Cities.listOfCities.Clear();
            Cities.listOfCities = CitiesParser.ParseCities(RegionsParser.GetRegionUrl(selectedRegion));
            Program.cities.PrintCities(Cities.listOfCities, checkedListBoxCities);
        }

        private void checkedListBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGetWeather.Enabled = true;

            if (Convert.ToInt32(checkedListBoxCities.CheckedItems.Count.ToString()) < 1)
                buttonGetWeather.Enabled = false;
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            FileSaver.SaveFile(saveFileDialog, richTextBoxWeather);
        }
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Messages.INFO);
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Messages.ABOUT);
        }
    }
}