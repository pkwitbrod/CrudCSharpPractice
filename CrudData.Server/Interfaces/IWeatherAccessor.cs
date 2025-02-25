namespace CrudData.Server.Interfaces
{
    public interface IWeatherAccessor
    {
        public int GetTemprature();

        public string GetTempratureSummary();
    }
}
