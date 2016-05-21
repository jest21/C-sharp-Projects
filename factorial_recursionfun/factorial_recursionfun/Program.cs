using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursionfun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int number = int.Parse(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} Factorial is {1}",number,fact);
            Console.ReadKey();
        }
        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}
