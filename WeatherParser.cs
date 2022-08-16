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

    public class WeatherParser
    {
        public string temperature { get; set; }
        public string wind { get; set; }
        public string description { get; set; }
        public List<Forecast> forecast { get; set; }

        public WeatherParser GetWeather(string city)
        {
            string url = $"https://goweather.herokuapp.com/weather/{city}";

            using (var webClient = new WebClient())
            {
                string response;

                try
                {
                    response = webClient.DownloadString(url);
                }
                catch (Exception)
                {
                    response = "{\"temperature\":\"Нет данных\",\"wind\":\"Нет данных\",\"description\":\"Нет данных\",\"forecast\":[{\"day\":\"1\",\"temperature\":\"Нет данных\",\"wind\":\"Нет данных\"},{\"day\":\"2\",\"temperature\":\"Нет данных\",\"wind\":\"Нет данных\"},{\"day\":\"3\",\"temperature\":\"Нет данных\",\"wind\":\"Нет данных\"}]}";
                }
                
                WeatherParser weather = JsonConvert.DeserializeObject<WeatherParser>(response);

                return weather;
            }
        }

        public async Task<WeatherParser> GetWeatherAsync(string city)
        {
            return await Task.Run(() => GetWeather(city));
        }

        public void DisplayWeather(WeatherParser weather, RichTextBox textBox, string cityName)
        {
            textBox.AppendText($"{cityName}. Прогноз погоды на текущий день:\n");
            textBox.AppendText("\nПогода: " + weather.description);
            textBox.AppendText("\nВетер: " + weather.wind);
            textBox.AppendText("\nТемпература: " + weather.temperature);

            foreach (var item in weather.forecast)
            {
                textBox.AppendText("\n\nДень: " + item.day);
                textBox.AppendText("\nТемпература: " + item.temperature);
                textBox.AppendText("\nВетер: " + item.wind);
            }

            textBox.AppendText("\n============================\n\n");
        }
    }



}
