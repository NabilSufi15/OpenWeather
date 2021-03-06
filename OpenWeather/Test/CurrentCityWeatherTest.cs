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
        public void TimeZoneCheck()
        {
            Assert.AreEqual(0, currentWeather.weatherDTO.CurrentWeather.timezone);
        }

        [Test]
        public void CoordLatitudeCheck()
        {
            Assert.AreEqual(51.5099983f, currentWeather.weatherDTO.CurrentWeather.coord.lat);
        }

        [Test]
        public void CoordLongitudeCheck()
        {
            Assert.AreEqual(-0.129999995f, currentWeather.weatherDTO.CurrentWeather.coord.lon);
        }

        [Test]
        public void TemperatureCheck()
        {
            Assert.That(currentWeather.weatherDTO.CurrentWeather.main.temp.ToString, Is.Not.Empty);
        }

        [Test]
        public void WeatherDescriptionCheck()
        {
            Assert.That(currentWeather.weatherDTO.CurrentWeather.weather[0].description, Is.Not.Empty);
        }

        [Test]
        public void WindSpeedCheck()
        {
            Assert.That(currentWeather.weatherDTO.CurrentWeather.wind.speed.ToString, Is.Not.Empty);
        }

        [Test]
        public void HumidityCheck()
        {
            Assert.That(currentWeather.weatherDTO.CurrentWeather.main.humidity.ToString, Is.Not.Empty);
        }

    }
}
