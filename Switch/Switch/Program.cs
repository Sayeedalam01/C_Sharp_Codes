using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            switch (b)
            {

                case 0:
                    Console.WriteLine("zero");
                    break;
                default:
                    Console.WriteLine("Not a zero.");
                    break;
            }
            
        }
    }
}
