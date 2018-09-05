using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2.Challenge1
{
    public class Fahrenheit
    {
        public double _temperature;

        public Fahrenheit()
        {

        }

        public Fahrenheit(double temperature)
        {
            _temperature = temperature;
        }

        public static explicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius((5.0 / 9.0) * (fahrenheit._temperature - 32));
        }
    }
}
