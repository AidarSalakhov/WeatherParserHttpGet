using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace WeatherParserHttpGet
{
    public class Forecast
    {
        public string day { get; set; }
        public string temperature { get; set; }
        public string wind { get; set; }
    }

    public class WeatherResponse
    {
        public string temperature { get; set; }
        public string wind { get; set; }
        public string description { get; set; }
        public List<Forecast> forecast { get; set; }

        public WeatherResponse GetWeather(string city = "Moscow")
        {
            string url = $"https://goweather.herokuapp.com/weather/{city}";

            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);

                WeatherResponse weather = JsonConvert.DeserializeObject<WeatherResponse>(response);

                return weather;
            }
        }

        public void DisplayWeather (WeatherResponse weather, RichTextBox textBox)
        {
            textBox.Text = "Прогноз погоды на текущий день:";

            textBox.Text += "Погода: " + weather.description;
            textBox.Text += "Ветер: " + weather.wind;
            textBox.Text += "Температура: " + weather.temperature;

            foreach (var item in weather.forecast)
            {
                textBox.Text += "\nДень: " + item.day;
                textBox.Text += "Температура: " + item.temperature;
                textBox.Text += "Ветер: " + item.wind;
            }
        }
    }

    

}
