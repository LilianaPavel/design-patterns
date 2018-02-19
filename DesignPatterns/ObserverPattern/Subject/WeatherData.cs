using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern
{
    class WeatherData : ISubject
    {
        List<IObserver> observers;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DeregisterObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
        
        public void NotifyObservers()
        {
            observers.ForEach(observer => observer.Update(this.Temperature, this.Humidity, this.Pressure));
        }

        public float Temperature
        {
            get;
            private set;
        }

        public float Pressure
        {
            get;
            private set;
        }

        public float Humidity
        {
            get;
            private set;
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.Temperature = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
            this.MeasurementsChanged();
        }
    }
}
