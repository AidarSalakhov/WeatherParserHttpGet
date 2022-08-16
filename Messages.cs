using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParserHttpGet
{
    internal class Messages
    {
        public const string ABOUT = "Программа: Weather Parser HTTP GET v 1.0 (с)" +
                "\nРазработчик: Айдар Салахов" +
                "\nКазань, 2022\n" +
                "\nПарсинг погоды производится с сайта: https://goweather.herokuapp.com/weather/" +
                "\nПарсинг городов производится с сайта: https://world-weather.ru/pogoda/russia/";

        public const string INFO = "Как пользоваться программой:\n" +
                "1) Выберите регион\n" +
                "2) Выберите один или несколько городов\n" +
                "3) Нажмите кнопку [Узнать погоду]\n" +
                "4) При необходимости сохраните данные в файл\n";

        public const string REGIONS_PARSE_ERROR = "Не удалось загрузить регионы.\n" +
                    $"Сайт недоступен.\n" +
                    "Попробуйте позже.";

        public const string CITIES_PARSE_ERROR = "Не удалось загрузить города этого региона.\n" +
                    $"Сайт недоступен.\n" +
                    "Выберите другой регион, или попробуйте позже.";

        public const string NO_DATA_ERROR = "Нет данных для сохранения. Сначала получите данные о погоде.";

        public const string FILE_SAVED = "Файл сохранён.";
    }
}
