namespace Weather.Domain
{
    public interface IWeatherService
    {
        IReadOnlyCollection<WeatherForecast> GetWeatherForecasts(int days);

        IReadOnlyCollection<WeatherForecast> GetWeatherForecasts(string city, int days);
    }
}
