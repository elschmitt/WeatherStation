using System;

namespace WeatherStation
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastpressure;
        private WeatherData _weatherData;
        private string _forecast;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            _lastpressure = _currentPressure;
            _currentPressure = pressure;

            display();
        }
        public void display()
        {
            _forecast = "Forecast: ";
            if (_currentPressure > _lastpressure)
            {
                _forecast += "Improving weather on the way";
            }
            else if (_currentPressure == _lastpressure)
            {
                _forecast += "More of the same";
            }
            else if (_currentPressure < _lastpressure)
            {
                _forecast += "Watch out for cooler, rainy weather";
            }

            Console.WriteLine(_forecast);
        }
    }
}
