using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_or_even
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter a number:");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("the number is even ");
                
            }
            else
            {
                Console.WriteLine("the number is odd ");
               
            }
            Console.ReadLine(); 
        }
    }
}
