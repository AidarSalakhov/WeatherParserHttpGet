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

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void îÏðîãðàììåToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

            selectedCityList.Add(citiesCheckedListBox.SelectedItem.ToString());
        }

        private void clearRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }

    
}