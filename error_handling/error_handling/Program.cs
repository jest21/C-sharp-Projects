using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace error_handling
{
    class Program
    {

      static void Main(string[] args)
      {
         Console.WriteLine("Enter a & b:");
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         try
         {
            if(b == 0)
            {
               throw (new ZeroException("Zero found"));
            }
            else
            {
               Console.WriteLine("Result: {0}", a/b);
            }
         }
         catch(ZeroException e)
         {
            Console.WriteLine("ZeroException: {0}", e.Message);
         }
         Console.ReadKey();
      }
   }
}

public class ZeroException: Exception
{
   public ZeroException(string message): base(message)
   {

   }
}
        
    

