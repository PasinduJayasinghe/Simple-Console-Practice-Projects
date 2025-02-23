using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WeatherApi.Controllers;


namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var rng = new Random();
                var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                }).ToArray();

                return Ok(forecast);
            }
            catch (Exception ex)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WeatherForecastController.cs");
                _logger.LogError(ex, "Error in {FilePath} - Status Code: {StatusCode}", filePath, 500);
                return StatusCode(500, "An error occurred while fetching weather data.");
            }
        }
    }

   
}
