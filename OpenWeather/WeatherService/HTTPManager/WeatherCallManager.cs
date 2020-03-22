using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace OpenWeather.WeatherService.HTTPManager
{
    public class WeatherCallManager
    {
        private readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetCurrentWeather(string city)
        {
            var request = new RestRequest($"/weather?q={city}&{AppConfigReader.ApiUrlMod}{AppConfigReader.ApiKey}");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
