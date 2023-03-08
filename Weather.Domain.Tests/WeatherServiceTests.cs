using Xunit;

namespace Weather.Domain.Tests
{
    public class WeatherServiceTests
    {
        private readonly WeatherService _weatherService = new WeatherService();

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        public void Should_Return_Forecasts_For_Specified_Number_Of_Days(int days)
        {
            var forecast = _weatherService.GetWeatherForecasts(days);

            Assert.Equal(days, forecast.Count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-123)]
        public void Should_Throw_Argument_Exception_When_Days_Are_Less_Than_One(int days)
        {
            Assert.Throws<ArgumentException>(() => _weatherService.GetWeatherForecasts(days));
        }

        [Fact]
        public void Should_Throw_Argument_Exception_When_City_Is_Empty()
        {
            Assert.Throws<ArgumentException>(() => _weatherService.GetWeatherForecasts("", 12));
        }
    }
}