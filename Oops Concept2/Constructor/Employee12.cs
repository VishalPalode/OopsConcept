using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Constructor
{
    internal class Employee12
    {
        public int id;
        public string name;
        public float salary;
        public Employee12(int i, string s, float n)
        {
            id = i;
            name = s;
            salary = n;


        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
}
