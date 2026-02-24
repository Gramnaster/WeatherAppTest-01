using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WeatherAppTest.Models;

namespace WeatherService.ServiceContracts
{
    public interface IWeatherService
    {
        public List<CityWeather> GetWeatherDetails();
        public CityWeather? GetWeatherByCityCode(string CityCode);
    }
}
