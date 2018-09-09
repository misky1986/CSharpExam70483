using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3.Challenge1
{
    public class Boat : Vehicle
    {
        public override void Run()
        {
            base.Wheels = 0;
            base.Speed = 200;

            Console.WriteLine($"The chosen vehicle is a {this.GetType().Name} with {base.Wheels} wheels and a max speed of {base.Speed}");
        }
    }
}
