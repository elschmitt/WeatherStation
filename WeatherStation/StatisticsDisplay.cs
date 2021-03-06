﻿using System;

namespace WeatherStation
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            _tempSum += temperature;
            _numReadings++;

            if (temperature > _maxTemp)
            {
                _maxTemp = temperature;
            }

            if (temperature < _minTemp)
            {
                _minTemp = temperature;
            }
            display();
        }
        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings) + "/" + _maxTemp + "/" + _minTemp);
        }
    }
}
