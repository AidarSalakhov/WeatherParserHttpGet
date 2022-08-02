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

        public WeatherResponse GetWeather(string city)
        {
            string url = $"https://goweather.herokuapp.com/weather/{city}";

            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);

                WeatherResponse weather = JsonConvert.DeserializeObject<WeatherResponse>(response);

                return weather;
            }
        }

        public void DisplayWeather (WeatherResponse weather, RichTextBox textBox, string cityName)
        {
            textBox.Text = $"{cityName}. Прогноз погоды на текущий день:\n";

            textBox.Text += "\nПогода: " + weather.description;
            textBox.Text += "\nВетер: " + weather.wind;
            textBox.Text += "\nТемпература: " + weather.temperature;

            foreach (var item in weather.forecast)
            {
                textBox.Text += "\n\nДень: " + item.day;
                textBox.Text += "\nТемпература: " + item.temperature;
                textBox.Text += "\nВетер: " + item.wind;
            }
        }
    }

    

}
