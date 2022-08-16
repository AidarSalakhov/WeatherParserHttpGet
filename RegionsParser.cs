﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserHttpGet
{
    internal class RegionsParser
    {
        private string? _regionName { get; set; }
        private string? _regionUrl { get; set; }
        public static List<RegionsParser> listOfRegions = new List<RegionsParser>();

        public static List<RegionsParser> ParseRegions()
        {
            string url = "https://world-weather.ru/pogoda/russia/";

            try
            {
                HtmlWeb htmlWeb = new HtmlWeb();
                var htmlDoc = htmlWeb.Load(url);
                var citiesReg = htmlDoc.DocumentNode.SelectNodes("//ul[@class='cities reg']//li[not(contains(@class,'cities-letter'))]//a[@href]");

                foreach (var item in citiesReg)
                {
                    RegionsParser region = new RegionsParser();
                    region._regionName = item.InnerText;
                    region._regionUrl = item.GetAttributeValue("href", null);
                    listOfRegions.Add(region);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить регионы.\n" +
                    $"Сайт {url} недоступен.\n" +
                    "Попробуйте позже.");
                throw;
            }

            return listOfRegions;
        }
                
        public static string GetRegionUrl(string regionName)
        {
            foreach (var region in listOfRegions)
            {
                if (region._regionName == regionName)
                    return region._regionUrl;
            }

            return string.Empty;
        }

        public void PrintRegions(List<RegionsParser> regions, ListBox listBox)
        {
            string[] regionsList = new string[regions.Count];

            for (int i = 0; i < regionsList.Length; i++)
                regionsList[i] = regions[i]._regionName;

            listBox.Items.AddRange(regionsList);
        }
    }
}