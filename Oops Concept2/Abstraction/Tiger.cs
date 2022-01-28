using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstraction
{
    internal class Tiger:Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Abstract method");
        }
    }
}
