using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jg = new int[4][];

            jg[0] = new int[] {1, 2, 3, 4};
            jg[1] = new int[] {2, 3, 4};  
            jg[2] = new int[] {3,5};
            jg[3] = new int[] {4};

            for (int i = 0; i < jg.Length; i++)
            {
                for (int j = 0; j < jg[i].Length; j++)
                {
                    Console.Write(jg[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
