using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class Program
    {

        class Box
        {
            private double length;   
            private double breadth;  
            private double height;   

            public double getVolume()
            {
                return length * breadth * height;
            }

            public void setLength(double len)
            {
                length = len;
            }

            public void setBreadth(double brd)
            {
                breadth = brd;
            }

            public void setHeight(double hgt)
            {
                height = hgt;
            }

            // Overload + operator to add two Box objects.
            public static Box operator +(Box b, Box c)
            {
                Box box = new Box();
                box.length = b.length + c.length;
                box.breadth = b.breadth + c.breadth;
                box.height = b.height + c.height;
                return box;
            }

        }

   
        class Tester
        {
            static void Main(string[] args)
            { 
                
                    
                Box Box1 = new Box();  
                Box Box2 = new Box();   
                Box Box3 = new Box();   
                double volume = 0.0;
                Console.WriteLine("enter the value length,breadth and height for box1");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the value length, breadth and height for box2");
                int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());
                int f = int.Parse(Console.ReadLine());

                Box1.setLength(a);
                Box1.setBreadth(b);
                Box1.setHeight(c);
                Box2.setLength(d);
                Box2.setBreadth(e);
                Box2.setHeight(f);

                volume = Box1.getVolume();
                Console.WriteLine("Volume of Box1 : {0}", volume);
                volume = Box2.getVolume();
                Console.WriteLine("Volume of Box2 : {0}", volume);
                Box3 = Box1 + Box2;
                volume = Box3.getVolume();
                Console.WriteLine("Volume of Box3 : {0}", volume);
                Console.ReadKey();
            }
        }
        
    }
}
