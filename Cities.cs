﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserHttpGet
{
    internal class Cities
    {
        private string? _cityName;

        private string? _cityUrl;

        public static List<Cities> listOfCities = new List<Cities>();

        public static List<Cities> ParseCities(string url)
        {
            HtmlWeb htmlWeb = new HtmlWeb();

            var htmlDoc = htmlWeb.Load(url);

            var cityBlock = htmlDoc.DocumentNode.SelectNodes("//li[@class='city-block']//a[@href]");

            foreach (var item in cityBlock)
            {
                Cities city = new Cities();

                city._cityName = item.InnerText;

                city._cityUrl = item.GetAttributeValue("href", null);

                listOfCities.Add(city);
            }

            return listOfCities;
        }

        public static void PrintCities(List<Cities> cities)
        {

        }

        public static string GetCityUrl(int cityNumber)
        {
            Cities city = new Cities();

            city = listOfCities[cityNumber - 1];

            string cityUrl = $"https:{city._cityUrl}" ?? string.Empty;

            return cityUrl;
        }

        public static string GetCityName(int cityNumber)
        {
            Cities city = new Cities();

            city = listOfCities[cityNumber - 1];

            string cityName = city._cityName ?? string.Empty;

            return cityName;
        }
    }
}
