using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept.Encapsulation
{
    internal class Rectangle
    {
        public double length;
        public double width;
        public void RectangleDetails()
        {
            Console.WriteLine("enter length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter width");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
      
    }
}

