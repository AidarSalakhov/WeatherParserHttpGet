using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserHttpGet
{
    internal class CitiesParser
    {
        private string? _cityName;
        private string? _cityUrl;
        public static List<CitiesParser> listOfCities = new List<CitiesParser>();

        public static List<CitiesParser> ParseCities(string url)
        {
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                var htmlDoc = htmlWeb.Load(url);
                var cityBlock = htmlDoc.DocumentNode.SelectNodes("//li[@class='city-block']//a[@href]");

                foreach (var item in cityBlock)
                {
                    CitiesParser city = new CitiesParser();
                    city._cityName = item.InnerText;
                    city._cityUrl = item.GetAttributeValue("href", null);
                    listOfCities.Add(city);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить города этого региона.\n" +
                    $"Сайт {url} недоступен.\n" +
                    "Выберите другой регион, или попробуйте позже.");
                return listOfCities;
            }

            return listOfCities;
        }

        public void PrintCities(List<CitiesParser> cities, ListBox listBox)
        {
            string[] citiesList = new string[cities.Count];

            for (int i = 0; i < citiesList.Length; i++)
                citiesList[i] = cities[i]._cityName;

            listBox.Items.Clear();
            listBox.Items.AddRange(citiesList);
        }
    }
}
