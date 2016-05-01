using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6]; int i;

            Console.WriteLine("enter a array of elements ");
            int largest = -100000, smallest=99999999;
            for ( i=0; i < 6; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > largest)
                    largest = arr[i];
                if (arr[i] < smallest)
                    smallest = arr[i];
            }
            Console.WriteLine("sorted elements");
            Array.Sort(arr);
            foreach (int j in arr) Console.WriteLine(j + "");
            Console.WriteLine("\nLargest element=" + largest + "\nSmallest element=" + smallest);
            Console.ReadLine();
            


            string[] str = new string[6]; //{ "ab","ac","af","ae","ad","aa"}
            Console.WriteLine("\n enter a array of strings ");
            for (i = 0; i < 6; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("sorted string");
            Array.Sort(str,StringComparer.InvariantCulture);
           Array.ForEach(str,x=>Console.WriteLine(x));
           Console.ReadLine();
        }
    }
}
