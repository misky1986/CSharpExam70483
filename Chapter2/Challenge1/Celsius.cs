using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2.Challenge1
{
    public class Celsius
    {
        public double _temperature;

        public Celsius()
        {

        }

        public Celsius(double temperature)
        {
            _temperature = temperature;
        }        

        public static implicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit(celsius._temperature*1.8+32);
        }
    }
}
