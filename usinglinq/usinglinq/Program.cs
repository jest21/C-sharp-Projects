using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usinglinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 32, 85, 14, 51, 96, 700, 65, 100, 300, 79, 55, 400 };
            var program = from num in numbers where num < 50 select num;
            Console.WriteLine("Numbers less than 50 are :");
            foreach (int i in program)
            {
                Console.Write(i + "\t");
            }
            var prgram = from num in numbers where num > 50 select num;
            Console.WriteLine("\nNumbers more than 50 are :");
            foreach (int i in prgram)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();

        }
    }
}
