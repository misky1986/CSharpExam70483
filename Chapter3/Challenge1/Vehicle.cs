using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3.Challenge1
{
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
        public int Speed { get; set; }

        public abstract void Run();
    }
}
