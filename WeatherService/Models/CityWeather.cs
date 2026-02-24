using System.ComponentModel.DataAnnotations;

namespace WeatherAppTest.Models
{
    public class CityWeather
    {
        [Required(ErrorMessage = "{0} cannot be empty or null")]
        public required string CityUniqueCode { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty or null")]
        public required string CityName { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty or null")]
        public DateTime DateAndTime { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty or null")]
        public int? TemperatureFahrenheit { get; set; }
    }
}
