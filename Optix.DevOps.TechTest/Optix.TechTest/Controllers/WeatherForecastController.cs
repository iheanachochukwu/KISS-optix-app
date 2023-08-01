using Microsoft.AspNetCore.Mvc;

namespace Optix.TechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherService _service;

        public WeatherForecastController(WeatherService service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.Get();
        }
    }
}