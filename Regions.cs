using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParserHttpGet
{
    internal class Regions
    {
        public string regionName { get; set; }
        public string regionUrl { get; set; }

        public static List<Regions> listOfRegions = new List<Regions>();
    }
}
