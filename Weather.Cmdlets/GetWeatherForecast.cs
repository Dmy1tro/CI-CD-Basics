using System.Management.Automation;
using Weather.Domain;

namespace Weather.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "WeatherForecast")]
    public class GetWeatherForecast : Cmdlet
    {
        private readonly IWeatherService _weatherService;

        public GetWeatherForecast(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public GetWeatherForecast() : this(new WeatherService())
        {
        }

        [Parameter(Mandatory = false)]
        public int Days { get; set; } = 7;

        protected override void ProcessRecord()
        {
            var forecast = _weatherService.GetWeatherForecasts(Days);

            WriteObject(forecast);
        }
    }
}