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
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void îÏğîãğàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void îÏğîãğàììåToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}