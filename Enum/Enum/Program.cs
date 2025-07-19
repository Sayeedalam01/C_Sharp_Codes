using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum weekdays
        {
            sat,
            sun,
            mon,
            tue,
            wed,
            thu
        }
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.sat);
            Console.WriteLine(weekdays.sun);
            Console.WriteLine((int)weekdays.sat);
            Console.WriteLine((int)weekdays.sun);
        }
    }
}
