// See https://aka.ms/new-console-template for more information
using System;
using MyUtilities;
namespace myfirstprogram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Places to go");
            WeatherUtilities.Report("London",5,15);
            WeatherUtilities.Report("New York", WeatherUtilities.FahrenheitToCelsius(65), 50);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(75), 65);

        }

        static float FarenheightToCelcius(float tempFarenheight)
        {
            float tempCelcius = (tempFarenheight - 32) / 1.8f; //1.8f - f indicates float
            return tempCelcius;
        }
        
        static float CelciusToFarenheight(float tempCelcius)
        {
            var tempFarenheight = (tempCelcius + 32) * 1.8f;
            return tempFarenheight;
        }
    }
}

