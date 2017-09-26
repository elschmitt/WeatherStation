using System;

namespace WeatherStation
{
    class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private Subject _weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            display();
        }
        public void display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }
    }
}
