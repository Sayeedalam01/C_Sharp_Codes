using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDeductNumbers
{
    internal class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int deduct(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(20, 2));
            Console.WriteLine(deduct(20, 2));
        }
    }
}
