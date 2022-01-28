using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Pass_by_value_and_referance
{
    internal class PassByValue
    {
        static void ChangeValue(int i)
        {
            i = 200;
            Console.WriteLine(i);
        }
        public static void Test()
        {
            int i = 100;
            Console.WriteLine("value of i before callling changemethod:" + i);
            ChangeValue(i);
            Console.WriteLine("value of i after calling changemethod:" + i);
        }
    }
}
