using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 0, k = 0;
            do{Console.WriteLine("enter the value of n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe prime numbers are : ");
            for (i = 2; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                    Console.WriteLine(i);
                k = 0;

            }
            Console.ReadLine();
            }while(true);
        }
    }
}
