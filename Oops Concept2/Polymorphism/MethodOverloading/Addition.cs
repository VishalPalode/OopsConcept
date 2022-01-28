using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept.Polymorphism.MethodOverloading
{
    internal class Addition
    {
        public void SumOfNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("sum:" + c);
        }
        public void SumOfNumbers(int a, int b, int d)
        {
            int c = a + b + d;
            Console.WriteLine("sum:" + c);
        }
    }
}
