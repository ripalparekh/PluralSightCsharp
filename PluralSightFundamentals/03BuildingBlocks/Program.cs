// See https://aka.ms/new-console-template for more information
using System;
namespace myfirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");   

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

