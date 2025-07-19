using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare_and_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            float b = 3.4f;
            double c = 6.6;
            string d = "Hi there";
            Console.WriteLine("Integer Value: {2} {0} {1}",  a, b, c);
            Console.WriteLine("Values: " + c+" "+d+" "+a);
        }
    }
}
