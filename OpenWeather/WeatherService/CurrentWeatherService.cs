using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        //instance of the call manager that manages the call to the API to get the data
        public WeatherCallManager weatherCallManager = new WeatherCallManager();

        //instance of the DTO that tranforms our data into the format of our model
        public WeatherDTO weatherDTO = new WeatherDTO();

        //current weather information retrieved 
        public string currentWeather;

        //rates converted to JObject so we manipulate later in useful methods 
        //public JObject json_weather;

        public CurrentWeatherService()
        {
            currentWeather = weatherCallManager.GetCurrentWeather("London");
            weatherDTO.DeserializeCurrentWeather(currentWeather);
            //json_weather = JsonConvert.DeserializeObject<JObject>(currentWeather);
        }



    }
}
