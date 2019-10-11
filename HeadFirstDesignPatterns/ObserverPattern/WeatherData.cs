using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPatterns.ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humudity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.update(temperature, humudity, pressure);
            }
        }

        public void measurementChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humudity = humidity;
            this.pressure = pressure;
            measurementChanged();
        }
    }
}
