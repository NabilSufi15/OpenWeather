using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.WeatherService.DataHandling
{
    public class WeatherDTO
    {
        //class is the model of data
        public Rootobject CurrentWeather { get; set; }

        //Method that creates the above object following passing in the response from the API
        public void DeserializeCurrentWeather(string CurrentWeatherResponse)
        {
            CurrentWeather = JsonConvert.DeserializeObject<Rootobject>(CurrentWeatherResponse);
        }
    }
}
