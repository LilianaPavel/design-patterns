using System;

namespace DesignPatterns.ObserverPattern
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();

            CurrentConditionsDisplay curDisplay = new CurrentConditionsDisplay(data);
            ForecastDisplay forecastDisplay = new ForecastDisplay(data);
            StatisticsDisplay statDisplay = new StatisticsDisplay(data);

            data.SetMeasurements(80, 65, 30.4f);
            data.SetMeasurements(82, 70, 29.2f);
            data.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
