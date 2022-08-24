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
        public static List<Cities> ParseCities(string url)
        {
            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                var htmlDoc = htmlWeb.Load(url);
                var cityBlock = htmlDoc.DocumentNode.SelectNodes("//li[@class='city-block']//a[@href]");

                foreach (var item in cityBlock)
                {
                    Cities city = new Cities();
                    city.cityName = item.InnerText;
                    city.cityUrl = item.GetAttributeValue("href", null);
                    Cities.listOfCities.Add(city);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.CITIES_PARSE_ERROR);
                return Cities.listOfCities;
            }

            return Cities.listOfCities;
        }

        public void PrintCities(List<Cities> cities, ListBox listBox)
        {
            string[] citiesList = new string[cities.Count];

            for (int i = 0; i < citiesList.Length; i++)
                citiesList[i] = cities[i].cityName;

            listBox.Items.Clear();
            listBox.Items.AddRange(citiesList);
        }
    }
}
