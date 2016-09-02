using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amt_denomination
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] den={1000,500,100,50,20,10,5,2,1};
            Console.WriteLine("enter the amount\n");
            int amt = int.Parse(Console.ReadLine());
            int total=0; int count = 0;
            int copy = amt;
            Console.WriteLine("\n denominations are : \n");

            for (int i = 0; i < 9; i++)
            {
                count = amt / den[i];
                if (count != 0)
                {
                    Console.WriteLine(den[i] + "\t *  " + count + "\t=" + den[i] * count);
                }
                total = total + count;
                amt = amt % den[i];
            }
            Console.WriteLine("total\t=" + copy);
            Console.WriteLine("\n" + total);
            Console.ReadLine();

        }
    }
}
