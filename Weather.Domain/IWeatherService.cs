namespace Weather.Domain
{
    public interface IWeatherService
    {
        IReadOnlyCollection<WeatherForecast> GetWeatherForecasts(int days);
    }
}
