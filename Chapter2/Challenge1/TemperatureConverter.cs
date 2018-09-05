using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2.Challenge1
{
    class TemperatureConverter
    {
        public void ConverterProgram()
        {
            int temperatureScaleChosen = ChoseTemperateScale();

            switch (temperatureScaleChosen)
            {
                case 1:
                    EnterCelsius();
                    break;
                case 2:
                    EnterFahrenheit();
                    break;
                default:
                    break;
            }
            Console.Read();
        }

        private void EnterCelsius()
        {
            Celsius celsius = new Celsius();
            Console.Write("Enter celsius: ");
            celsius._temperature = double.Parse(Console.ReadLine());
            Fahrenheit fahrenheit = (Fahrenheit)celsius;
            Console.Write($"Celsius temperature shown in Fahrenheit temperature scale: {fahrenheit._temperature}");
            Console.Read();
        }

        private void EnterFahrenheit()
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            Console.Write("Enter fahrenheit: ");
            fahrenheit._temperature = double.Parse(Console.ReadLine());
            Celsius celsius = (Celsius)fahrenheit;
            Console.Write($"Celsius temperature shown in Fahrenheit temperature scale: {celsius._temperature}");            
        }

        private int ChoseTemperateScale()
        {
            Console.WriteLine("Chose which temperature scale to use!");
            Console.WriteLine($"1. Celcius: ");
            Console.WriteLine($"2. Fahrenheit: ");            
            return int.Parse(Console.ReadLine());            
        }
    }
}
