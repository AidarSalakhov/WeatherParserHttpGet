using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParserHttpGet
{
    internal class FileSaver
    {
        public static void SaveFile(SaveFileDialog saveFileDialog, RichTextBox richTextBoxWeather)
        {
            if (FormMain.selectedCityList.Count < 1)
            {
                MessageBox.Show(Messages.NO_DATA_ERROR);
                return;
            }

            saveFileDialog.FileName = "Погода";
            saveFileDialog.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBoxWeather.Text.ToString(), Encoding.UTF8);
                MessageBox.Show(Messages.FILE_SAVED);
            }
        }
    }
}
