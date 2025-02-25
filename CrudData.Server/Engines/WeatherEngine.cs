using CrudData.Server.Interfaces;

namespace CrudData.Server.Engines
{
    public class WeatherEngine : IWeatherEngine
    {
        public WeatherEngine() { }
        public WeatherForecast GetWeatherForecast()
        {
            throw new NotImplementedException();
        }
    }
}
