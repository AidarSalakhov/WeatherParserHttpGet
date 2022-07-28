using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserHttpGet
{
    internal class Regions
    {
        private string? _regionName { get; set; }
        private string? _regionUrl { get; set; }

        public static List<Regions> listOfRegions = new List<Regions>();

        public static List<Regions> ParseRegions()
        {
            string url = "https://world-weather.ru/pogoda/russia/";

            HtmlWeb htmlWeb = new HtmlWeb();

            var htmlDoc = htmlWeb.Load(url);

            var citiesReg = htmlDoc.DocumentNode.SelectNodes("//ul[@class='cities reg']//li[not(contains(@class,'cities-letter'))]//a[@href]");

            foreach (var item in citiesReg)
            {
                Regions region = new Regions();

                region._regionName = item.InnerText;

                region._regionUrl = item.GetAttributeValue("href", null);

                listOfRegions.Add(region);
            }

            return listOfRegions;
        }

        public static string GetRegionUrl(int regionNumber)
        {
            Regions region = new Regions();

            region = listOfRegions[regionNumber - 1];

            string url = region._regionUrl ?? string.Empty;

            return url;
        }

        public static int GetRegionIndex(string regionName)
        {
            Regions region = new Regions();

            region._regionName = regionName;

            int index = listOfRegions.IndexOf(region);

            return index;
        }

        public void PrintRegions(List<Regions> regions, ListBox listBox)
        {
            string[] regionsList = new string[regions.Count];

            for (int i = 0; i < regionsList.Length; i++)
            {
                regionsList[i] = regions[i]._regionName;
            }

            listBox.Items.AddRange(regionsList);
        }
    }
}
