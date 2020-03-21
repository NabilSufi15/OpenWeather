using OpenWeather.WeatherService.DataHandling;
using OpenWeather.WeatherService.HTTPManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.WeatherService
{
    public class CurrentWeatherService
    {
        public WeatherCallManager weatherCallManger = new WeatherCallManager();

        public WeatherDTO weatherDTO = new WeatherDTO();
    }
}
