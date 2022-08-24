using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserHttpGet
{
    internal class RegionsParser
    {
        public static List<Regions> ParseRegions()
        {
            string url = "https://world-weather.ru/pogoda/russia/";

            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                var htmlDoc = htmlWeb.Load(url);
                var citiesReg = htmlDoc.DocumentNode.SelectNodes("//ul[@class='cities reg']//li[not(contains(@class,'cities-letter'))]//a[@href]");

                foreach (var item in citiesReg)
                {
                    Regions region = new Regions();
                    region.regionName = item.InnerText;
                    region.regionUrl = item.GetAttributeValue("href", null);
                    Regions.listOfRegions.Add(region);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.REGIONS_PARSE_ERROR);
                throw;
            }

            return Regions.listOfRegions;
        }
                
        public static string GetRegionUrl(string regionName)
        {
            foreach (var region in Regions.listOfRegions)
            {
                if (region.regionName == regionName)
                    return region.regionUrl;
            }

            return string.Empty;
        }

        public void PrintRegions(List<Regions> regions, ListBox listBox)
        {
            string[] regionsList = new string[regions.Count];

            for (int i = 0; i < regionsList.Length; i++)
                regionsList[i] = regions[i].regionName;

            listBox.Items.AddRange(regionsList);
        }
    }
}
