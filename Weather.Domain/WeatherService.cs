﻿namespace Weather.Domain
{
    public class WeatherService : IWeatherService
    {
        private static readonly string[] _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IReadOnlyCollection<WeatherForecast> GetWeatherForecasts(int days)
        {
            if (days < 1)
            {
                throw new ArgumentException("days should be greater or equal than 1");
            }

            var forecast = Enumerable.Range(1, days)
                .Select(index => new WeatherForecast
                (
                    DateTime.Now.AddDays(index),
                    Random.Shared.Next(-20, 55),
                    _summaries[Random.Shared.Next(_summaries.Length)]
                ))
                .ToArray();

            return forecast;
        }
    }
}
