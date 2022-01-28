using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Inheritance
{
    internal class Dog:Animal 
    {
        public string colour, size;
        public void output()
        {
            Console.WriteLine("display colour size");
        }
    }
}
