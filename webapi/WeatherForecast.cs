namespace webapi;

/// <summary>
/// Weather forecast for a specific day.<br/>
/// Yes, XML Doc markup <b>Works!</b>
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// Date being  forecasted
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Forecasted temperature in Celsius
    /// </summary>
    public int TemperatureC { get; set; }

    /// <summary>
    /// Forecasted temperature in Fahrenheit
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// Summary of forecasted weather
    /// </summary>
    public string? Summary { get; set; }
}
