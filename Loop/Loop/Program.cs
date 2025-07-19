using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 5; i++) { 
                Console.WriteLine(i);
            }
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            do { 
                Console.WriteLine(i);
                i++;
            } while (i < 15);
        }
    }
}
