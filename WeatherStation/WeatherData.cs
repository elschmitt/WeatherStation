using System;
using System.Collections;

namespace WeatherStation
{
    public class WeatherData : Subject
    {
        //You'll need to use NuGet to add System.Collections.NonGeneric for ArrayList to work.
        //Right click your project and choose Manage NuGet packages, then just search for the package and install.
        private ArrayList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }
        public void registerObserver(Observer o)
        {
            _observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
            {
                _observers.Remove(i);
            }
        }
        public void notifyObservers()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                Observer observer = (Observer)_observers[i];
                observer.update(_temperature, _humidity, _pressure);
            }
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            measurementsChanged();
        }
    }
}
