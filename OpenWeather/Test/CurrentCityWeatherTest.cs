﻿using NUnit.Framework;
using OpenWeather.WeatherService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Test
{
    [TestFixture]
    public class CurrentCityWeatherTest
    {
        private CurrentWeatherService currentWeather = new CurrentWeatherService();

        [Test]
        public void StatusCheck()
        {
            int success = 200;
            Assert.AreEqual(success, currentWeather.weatherDTO.CurrentWeather.cod);
        }

        [Test]
        public void CityCheck()
        {
            StringAssert.IsMatch("London", currentWeather.weatherDTO.CurrentWeather.name);
        }

        [Test]
        public void CountryCheck()
        {
            StringAssert.IsMatch("GB", currentWeather.weatherDTO.CurrentWeather.sys.country);
        }

        [Test]
        public void WindSpeedCheck()
        {
            Assert.AreEqual(4.6f, currentWeather.weatherDTO.CurrentWeather.wind.speed);
        }

    }
}
