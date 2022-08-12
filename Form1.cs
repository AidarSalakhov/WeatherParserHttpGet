using System.Text;

namespace WeatherParserHttpGet
{


    public partial class Form1 : Form
    {
        public static string selectedCity;

        public static List<string> selectedCityList = new List<string>();

        private static SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            Program.regions.PrintRegions(Regions.ParseRegions(), regionsListBox);
            regionsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bGetWeather.Enabled = false;

            richTextBox1.Clear();

            progressBar.Maximum = selectedCityList.Count() - 1;

            for (int i = 0; i < selectedCityList.Count(); i++)
            {
                progressBar.Value = i;
                labelDownloadStatus.Text = $"���������� �������� {(int)Math.Round((double)(100 * (i + 1)) / selectedCityList.Count())}%";
                var weather = await Program.weatherResponse.GetWeatherAsync(selectedCityList[i]);
                Program.weatherResponse.DisplayWeather(weather, richTextBox1, selectedCityList[i]);
            }

            foreach (int i in citiesCheckedListBox.CheckedIndices)
                citiesCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);

            selectedCityList.Clear();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedRegion = regionsListBox.SelectedItem.ToString();
            Cities.listOfCities.Clear();
            Cities.listOfCities = Cities.ParseCities(Regions.GetRegionUrl(selectedRegion));
            Program.cities.PrintCities(Cities.listOfCities, citiesCheckedListBox);
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

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� ������������ ����������:\n" +
                "1) �������� ������\n" +
                "2) �������� ���� ��� ��������� �������\n" +
                "3) ������� ������ [������ ������]\n" +
                "4) ��� ������������� ��������� ������ � ����\n" +
                "5) ������� ������ [�������� ������] � ��������� ������ �� ������ �������!");
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bGetWeather.Enabled = true;

            selectedCityList.Add(citiesCheckedListBox.SelectedItem.ToString());
        }

        private void clearRichTextBox_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            richTextBox1.Clear();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "������";
            saveFileDialog1.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text.ToString(), Encoding.UTF8);
                MessageBox.Show("���� ��������");
            }
        }

        private void ����������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���������: Weather Parser HTTP GET v 1.0 (�)" +
                "\n�����������: ����� �������" +
                "\n������, 2022\n" +
                "\n������� ������ ������������ � �����: https://goweather.herokuapp.com/weather/" +
                "\n������� ������� ������������ � �����: https://world-weather.ru/pogoda/russia/");
        }

        private void labelDownloadStatus_Click(object sender, EventArgs e)
        {

        }
    }


}