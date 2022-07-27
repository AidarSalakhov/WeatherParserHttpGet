namespace WeatherParserHttpGet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.weatherResponse.DisplayWeather(Program.weatherResponse.GetWeather(), richTextBox1);
            GetCities();
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

        public void GetCities()
        {
            try
            {
                StreamReader streamReader = new StreamReader("cities.txt");
                CitiesTreeBuilder tree = new CitiesTreeBuilder();
                var nodes = tree.GetListNode(streamReader).ToArray();
                treeView1.Nodes.Clear();
                foreach (var item in nodes) treeView1.Nodes.Add(item);
                streamReader.Dispose();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}