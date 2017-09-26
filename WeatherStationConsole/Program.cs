using System;
using WeatherStation;

namespace WeatherStationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation.WeatherStation.main(args);

            Console.WriteLine("Press Enter to Close Report");
            //This keeps the console open so we can see the results, otherwise it just closes itself.
            Console.ReadLine();
        }
    }
}