using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstraction
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("Non abstract method");
        }
    }
}
