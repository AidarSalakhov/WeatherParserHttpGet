namespace WeatherParserHttpGet
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.regions.PrintRegions(Regions.ParseRegions(), regionsListBox);
            Data.listBoxRegions = regionsListBox;
            regionsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.weatherResponse.DisplayWeather(Program.weatherResponse.GetWeather(), richTextBox1);
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

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

            string selectedRegion = regionsListBox.SelectedItem.ToString();

            Program.cities.PrintCities(Cities.ParseCities(Regions.GetRegionUrl(selectedRegion)), citiesListBox);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }

    
}