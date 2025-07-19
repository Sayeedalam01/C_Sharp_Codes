using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectEvenAge
{
    internal class Program
    {
        static string detect(int age) { 
            if(age % 2 == 1)
            {
                return "Odd";
            }
            else
            {
                return "Even";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your age is: " +detect(age));

            Console.ReadKey();
        }
    }
}
