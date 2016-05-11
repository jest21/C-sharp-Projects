using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        class Shape
        {
            public double length;
            public double breadth;
            public double height;
            public double side1;
            public double side2;

        }
        class Rectangle : Shape
        {
            public double perimeter()
            {
                return 2 * (length + breadth);
            }
            public double Area()
            {
                return length * breadth;
            }
        }
        class Triangle : Shape
        {
            public double perimeter()
            {
                return side1 + breadth + side2;
            }
            public double Area()
            {
                return (breadth * height) / 2;
            }
        }
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Rectangle r1 = new Rectangle();
            Triangle t1 = new Triangle();
            Console.WriteLine("Enter the values of length, breadth of the rectangle ");
            r1.length = int.Parse(Console.ReadLine());
            r1.breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values of side1, side2, breadth, height of the triangle ");
            t1.side1 = int.Parse(Console.ReadLine());
            t1.side2 = int.Parse(Console.ReadLine());
            t1.breadth = int.Parse(Console.ReadLine());
            t1.height = int.Parse(Console.ReadLine());
            Console.WriteLine("area of rectangle is  " + r1.Area());
            Console.WriteLine("perimeter of rectangle is  " + r1.perimeter());
            Console.WriteLine("area of triangle is  " + t1.Area());
            Console.WriteLine("perimeter of the triangle is " + t1.perimeter());
            Console.ReadLine();
        }
    }

}