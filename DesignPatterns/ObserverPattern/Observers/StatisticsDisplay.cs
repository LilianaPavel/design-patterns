﻿using System;

namespace DesignPatterns.ObserverPattern
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        ISubject weatherData;
        float temperature;
        float humidity;
        float pressure;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("StatisticsDisplay: temperature - {0}, humidity - {1}, pressure - {2}",
                temperature, humidity, pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            this.Display();
        }
    }
}
