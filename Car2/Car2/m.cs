using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    internal class m
    {
        static void Main(string[] args) { 
            Car2 c1 = new Car2();
            c1.Lid = 101;

            Console.WriteLine(c1.Lid);
            c1.Model = "Phantom";
            c1.Cc = 1400;
            Console.WriteLine(c1.Cc);
            c1.Color = "Red";
            Console.WriteLine(c1.Color);
            Console.WriteLine("Car Model: " +c1.Model);
        }
    }
}
