using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

/// <summary>
/// XML Docs for the controller are displayed now in Swagger UI and XML docs markup works.<br/>
/// This is a new line.<br/>
/// <ul>
/// <li>These</li>
/// <li>Are</li>
/// <li>Bullet</li>
/// <li>Points</li>
/// </ul>
/// </summary>
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

    /// <summary>
    /// XML Docs for the method itself. XML Docs don't seem to work here.<br/>
    /// This is a new line.
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
