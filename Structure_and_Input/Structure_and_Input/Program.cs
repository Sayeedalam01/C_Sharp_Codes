using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_and_Input
{
    struct students {
        public string name;
        public int age;
        public double cgpa;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s;
            
            s.name = Console.ReadLine();
            s.age = int.Parse(Console.ReadLine());
            s.cgpa = double.Parse(Console.ReadLine());

            Console.WriteLine(s.name);
            Console.WriteLine(s.age);
            Console.WriteLine(s.cgpa);
        }
    }
}
