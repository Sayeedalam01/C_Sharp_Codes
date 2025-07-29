using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Vehicle
    {
        int lid;
        int cc;
        public Vehicle() {
            Console.WriteLine("Vehicle's Default Constructor Called.");
        }
        ~Vehicle() {
            Console.WriteLine("Vehicle's Destructor called");
        }
        public Vehicle(int cc, int lid) { 
            this.lid = lid;
            this.cc = cc;
            Console.WriteLine("Vehicle's Parameterized Constructor called");
        }
        public string brand = "Ford";
        public void honk() {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
