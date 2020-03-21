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
        public CurrentWeatherModel CurrentWeather { get; set; }

        //Method that creates the above object following passinng in the response from the API
        public void DeserializeLatestRates(string CurrentWeatherResponse)
        {
            CurrentWeather = JsonConvert.DeserializeObject<CurrentWeatherModel>(CurrentWeatherResponse);
        }
    }
}
