using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_pgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Marks = new int[6];// { 1, 2, 8, 74, 58, 0 };
            int i;
            Console.WriteLine("\nenter a array of elements ");
            for (i = 0; i < 6; ++i)
            {
                Marks[i] = int.Parse(Console.ReadLine());
            }

            var maxres = (from m in Marks select m).Max();
            var minres = (from n in Marks select n).Min();
            Console.WriteLine("\nLargest value is " + maxres);
            Console.WriteLine("\nSmallest value is " + minres);
            Console.ReadLine();

        }
    }
}
