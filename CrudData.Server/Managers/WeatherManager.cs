using CrudData.Server.Interfaces;

namespace CrudData.Server.Managers
{
    public class WeatherManager: IWeatherManager
    {
        IWeatherAccessor _weatherAccessor;
        IWeatherEngine _weatherEngine;
        public WeatherManager(IWeatherEngine weatherEngine, IWeatherAccessor weatherAccessor) 
        { 
            _weatherEngine = weatherEngine;
            _weatherAccessor = weatherAccessor;
        }

        public WeatherForecast[] GetWeatherForecasts()
        {
            Console.WriteLine("Here");
            throw new NotImplementedException();
        }
    }
}
