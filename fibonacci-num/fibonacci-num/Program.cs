using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_num
{
    class Program
    {
        public static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the value of n:");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
                
            Console.WriteLine(fibonacci(i));
            Console.ReadLine();
        }
    }
}
