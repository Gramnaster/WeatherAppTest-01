using System.ComponentModel.DataAnnotations;
using WeatherAppTest.Models;
using WeatherService.ServiceContracts;

namespace WeatherService
{
    public class WeatherService : IWeatherService
    {
        private readonly List<CityWeather> _cityWeather;

        public WeatherService()
        {
            _cityWeather = [
                new CityWeather
                {
                    CityUniqueCode = "LDN",
                    CityName = "London",
                    DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
                    TemperatureFahrenheit = 33
                },
                new CityWeather
                {
                    CityUniqueCode = "NYC",
                    CityName = "New York City",
                    DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),
                    TemperatureFahrenheit = 60
                },
                new CityWeather
                {
                    CityUniqueCode = "PAR",
                    CityName = "Paris",
                    DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),
                    TemperatureFahrenheit = 82
                }
            ];
        }

        public IReadOnlyList<CityWeather> GetWeatherDetails()
        {
            return _cityWeather;
        }
        public CityWeather? GetWeatherByCityCode(string CityCode)
        {
            return _cityWeather.FirstOrDefault(city => city.CityUniqueCode.Equals(CityCode, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
