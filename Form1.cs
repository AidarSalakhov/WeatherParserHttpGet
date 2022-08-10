namespace WeatherParserHttpGet
{
    

    public partial class Form1 : Form
    {
        public static string selectedCity;

        public static List<string> selectedCityList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Program.regions.PrintRegions(Regions.ParseRegions(), regionsListBox);
            regionsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = selectedCityList.Count() - 1;

            for (int i = 0; i < selectedCityList.Count(); i++)
            {
                Program.weatherResponse.DisplayWeather(Program.weatherResponse.GetWeather(selectedCityList[i]), richTextBox1, selectedCityList[i]);
                progressBar1.Value = i;
            }

            clearRichTextBox.Enabled = true;
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
            button1.Enabled = true;

            selectedCityList.Add(citiesCheckedListBox.SelectedItem.ToString());
        }

        private void clearRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            selectedCityList.Clear();
            
            clearRichTextBox.Enabled = false;
            button1.Enabled = false;

            foreach (int i in citiesCheckedListBox.CheckedIndices)
            {
                citiesCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Environment.CurrentDirectory + "/weather.txt", richTextBox1.Text.ToString());
            MessageBox.Show("������ ������� ��������� � ���� weather.txt � ����� ���������");
        }

        private void ����������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���������: Weather Parser HTTP GET v 1.0 (�)" +
                "\n�����������: ����� �������" +
                "\n������, 2022\n" +
                "\n������� ������ ������������ � �����: https://goweather.herokuapp.com/weather/" +
                "\n������� ������� ������������ � �����: https://world-weather.ru/pogoda/russia/");
        }
    }

    
}