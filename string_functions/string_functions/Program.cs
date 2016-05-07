using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = "";
            Console.WriteLine(" enter a string for a: ");
            a = Console.ReadLine();
            Console.WriteLine(" enter a string for b: ");
            b = Console.ReadLine();
            Console.WriteLine("enter the 1st substring value ");
            int x = int.Parse( Console.ReadLine());
            Console.WriteLine("enter the 2nd substring value ");
            int y = int.Parse(Console.ReadLine());
            string sub = a.Substring(x, y);
            Console.WriteLine("\nsubstring : {0}", sub);
            Console.WriteLine("concatenation : {0}", string.Concat(a,b));
            Console.WriteLine("length of string a : {0}", a.Length.ToString());
            Console.WriteLine("length of string b : {0}", b.Length.ToString());
            Console.WriteLine("trimming of string a : {0}", a.Trim());
            Console.WriteLine("trimming of string b : {0}", b.Trim());
            Console.WriteLine("case conversion of string a : {0}", a.ToUpper());
            Console.WriteLine("case conversion of string  : {0}", b.ToUpper());
            Console.ReadLine();
        }
    }
}
