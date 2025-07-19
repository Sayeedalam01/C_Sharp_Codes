using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            Console.WriteLine("Enter Students: ");

            for (int i = 0; i < 5; i++) {
                students[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("S: " + students[i]);
            }
            for(int i=0; i<students.Length; i++){
                Console.WriteLine("S: " + students[i]);
            }
            foreach (string s in students) {
                Console.WriteLine("Foreach: "+s);
            }
            foreach (var s in students) {
                Console.WriteLine("Foreach+Var: " + s);
            }

            var a = 2;
            var b = 3.3;
            var c = "HII";
            Console.WriteLine("int: " + a);
            Console.WriteLine("double: " + b);
            Console.WriteLine("string: " + c);

            Console.ReadKey();
        }
    }
}
