using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car : Vehicle
    {
        int wheel;
        int max_speed;
        public Car() {
            Console.WriteLine("Car's Default Constructor called.");
        }
        public Car(int wheel, int max_speed) { 
            this.wheel = wheel;
            this.max_speed = max_speed;
            Console.WriteLine("Car's Parameterized Constructor called.");
        }
        public String modelname = "Mustang";
    }
}
