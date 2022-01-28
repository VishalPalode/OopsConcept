using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept.Polymorphism.MethodOverriding
{
    internal class PartTimeEmp:Employee
    {
        public void GetSalary()
        {
            Console.WriteLine("Salary is 250");

        }
    }
}

