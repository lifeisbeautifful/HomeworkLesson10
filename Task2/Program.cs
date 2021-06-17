using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте программу, в которой создайте статический класс Convector (конвектор). В теле класса Convector создайте два статических
    метода, первый CelsiusToFahrenheit (string temperatureCelsius) , который конвертирует значение температуры в Цельсиях в Фаренгейты, 
    и второй FahrenheitToCelsius (string temperatureFahrenheit), который конвертирует значение температуры в Фаренгейтах в значение 
    температуры в Цельсиях.Организуйте возможность взаимодействия пользователя с программой*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'F' to convert celcius to fahrenheit or 'C' to convert from fahrenheit to celcius: ");
            string userInput = Console.ReadLine();
            if (userInput == "F")
            {
                Console.Write("Enter temperature in celcius: ");
                string temperature = Console.ReadLine();
                temperature.CelsiusToFahrenheit();
            }else if (userInput == "C")
            {
                Console.Write("Enter temperature in fahrenheits: ");
                string temperature = Console.ReadLine();
                temperature.FahrenheitToCelsius();
            }
            else
            {
                Console.WriteLine("Invalid value was passed");
            }

            Console.ReadLine();
        }
    }
    public static class Convector
    {
        public static void CelsiusToFahrenheit(this string temperatureCelsius)
        {
            double celciusTemperature = Convert.ToDouble(temperatureCelsius);
            double temperatureFahrenheit = (celciusTemperature *1.8 + 32);
            Console.WriteLine("{0}C = {1}F",temperatureCelsius,Math.Round(temperatureFahrenheit,1));
        }
        public static void FahrenheitToCelsius(this string temperatureFahrenheit)
        {
            double fahrenheitTemperature = Convert.ToDouble(temperatureFahrenheit);
            double temperatureCelcius = (fahrenheitTemperature - 32) / 1.8;
            Console.WriteLine("{0}F = {1}C",temperatureFahrenheit,Math.Round(temperatureCelcius,1));
        }
    }
}
