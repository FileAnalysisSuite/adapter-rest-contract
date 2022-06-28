using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterSDK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }        

        [HttpGet("coolestState")]
        public WeatherForecast GetCoolestState()
        {
            return new WeatherForecast
            {
                TemperatureC = -2,
                Summary = "Very Cool",
                Date = DateTime.Now
            };
        }

        [HttpGet("hottestState")]
        public WeatherForecast GetHottestState()
        {
            return new WeatherForecast
            {
                TemperatureC = 42,
                Summary = "Very Hot",
                Date = DateTime.Now
            };
        }
    }
}
