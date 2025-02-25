using CrudData.Server.Interfaces;

namespace CrudData.Server.Accessors
{
    public class WeatherAccessor: IWeatherAccessor
    {
        public WeatherAccessor() { }

        public int GetTemprature()
        {
            throw new NotImplementedException();
        }

        public string GetTempratureSummary()
        {
            throw new NotImplementedException();
        }
    }
}
