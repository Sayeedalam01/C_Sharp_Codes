using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{

    struct students {
        public int id;
        public string name;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s;
            s.id = 1;
            s.name = "Neymar";
            s.age = 31;
            Console.WriteLine(s.id);
            Console.WriteLine(s.name);
            Console.WriteLine(s.age);
        }
    }
}
