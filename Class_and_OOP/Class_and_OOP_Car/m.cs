using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_OOP
{
    internal class m
    {
        static void Main(string[] args){
            Car c1 = new Car();

            c1.setLid(101);
            c1.setModel("Phantom");
            c1.setCc(4000);

            Console.WriteLine("Car id: "+c1.getLid());
            Console.WriteLine(c1.getModel());
            Console.WriteLine(c1.getCc());

            c1.printDetails();
        }
    }
}
