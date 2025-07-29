using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class m
    {
        static void Main(string[] args)
        {
           Car c1 = new Car();
            //Console.WriteLine(c1.modelname);
            //Console.WriteLine(c1.brand);
            //c1.honk();
            
            //Vehicle v1 = new Car();
            //v1.honk();

            Car c2 = new Car(120, 500);
            //Console.WriteLine(c2.wheel, c2.maxspeed);
            
        }
    }
}
