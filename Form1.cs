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
            Program.regions.PrintRegions(Regions.ParseRegions(), listBoxRegions);
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
                labelDownloadStatus.Text = $"���������� �������� {(int)Math.Round((double)(100 * (i + 1)) / selectedCityList.Count())}%";
            }
        }

        private void listBoxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegion = listBoxRegions.SelectedItem.ToString();
            Cities.listOfCities.Clear();
            Cities.listOfCities = Cities.ParseCities(Regions.GetRegionUrl(selectedRegion));
            Program.cities.PrintCities(Cities.listOfCities, checkedListBoxCities);
        }

        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� ������������ ����������:\n" +
                "1) �������� ������\n" +
                "2) �������� ���� ��� ��������� �������\n" +
                "3) ������� ������ [������ ������]\n" +
                "4) ��� ������������� ��������� ������ � ����\n");
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
            if (selectedCityList.Count < 1)
            {
                MessageBox.Show("��� ������ ��� ����������. ������� �������� ������ � ������.");
                return;
            }
            
            saveFileDialog.FileName = "������";
            saveFileDialog.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBoxWeather.Text.ToString(), Encoding.UTF8);
                MessageBox.Show("���� ��������");
            }
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���������: Weather Parser HTTP GET v 1.0 (�)" +
                "\n�����������: ����� �������" +
                "\n������, 2022\n" +
                "\n������� ������ ������������ � �����: https://goweather.herokuapp.com/weather/" +
                "\n������� ������� ������������ � �����: https://world-weather.ru/pogoda/russia/");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void clearRichTextBox_Click(object sender, EventArgs e)
        {
            
        }
        
        private void labelDownloadStatus_Click(object sender, EventArgs e)
        {

        }
    }
}