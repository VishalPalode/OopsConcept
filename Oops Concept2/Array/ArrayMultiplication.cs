using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept.Array
{
    internal class ArrayMultiplication
    {
        public static void GetArrrayMultiplication()
        {
            Console.WriteLine(" enter the length of the arrays ");
            int i = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[i], array2 = new int[i], multiplication = new int[i];
            Console.WriteLine(" enter integer elements of first array ");
            for (i = 0; i < 5; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("enter integer element of second array");
            for (i = 0; i < 5; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("multiplication of two arrays");
            for (i = 0; i < 5; i++)
            {
                multiplication[i] = array1[i] * array2[i];
                Console.WriteLine("{0}", multiplication[i]);

            }
        }
    }
}


        
