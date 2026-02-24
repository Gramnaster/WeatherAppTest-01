using Microsoft.AspNetCore.Mvc;
using WeatherAppTest.Models;
using WeatherService.ServiceContracts;

namespace WeatherAppTest.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            IReadOnlyList<CityWeather> cityWeatherData = _weatherService.GetWeatherDetails();
            //List<CityWeather> data = cityWeatherData.Get;
            return Ok(cityWeatherData);
        }

        [HttpGet("/weather/{cityCode:string}")]
        public IActionResult ViewCityWeather([FromRoute]string? cityCode)
        {
            if (string.IsNullOrWhiteSpace(cityCode))
            {
                return BadRequest("City Code is not supplied");
            }

            if (cityCode.Length != 3 || !cityCode.All(char.IsLetter))
            {
                return BadRequest("Invalid City Code format");
            }

            string? upcaseCityCode = cityCode.ToUpperInvariant();
            CityWeather? cityWeatherData = _weatherService.GetWeatherByCityCode(upcaseCityCode);

            if (cityWeatherData == null)
            {
                return NotFound($"City Code '{cityCode}' not found");
            }

            return Ok(cityWeatherData);
        }
    }
}
