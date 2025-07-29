using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[][] jg = new int[4][];
            int jg[0] = new int[] { 1, 2, 3, 4 };
            int jg[1] = new int[] { 1, 2, 3 };
            int jg[2] = new int[] { 1, 2 };
            int jg[3] = new int[] { 4 };

            for (int i = 0; i < jg.Length; i++)
            {
                for (int j = 0; j < jg[i].Lenght; j++)
                {
                    Console.WriteLine(jg[i][j] + " ");
                }
            }
        }
    }
}
