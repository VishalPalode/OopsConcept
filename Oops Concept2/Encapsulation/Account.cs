using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept.Encapsulation
{
    internal class Account
    {
        private double balance = 2000;
        public void setbalance(double balance1)
        {
            if (balance1 < 0)
                Console.WriteLine(" please enter valid amount like more than 100Rs");
            else
                this.balance = this.balance + balance1;
        }
        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
