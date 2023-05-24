using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amountToAdd)
        {
            _balance += amountToAdd;
        }
        public double GetBalance() 
        { 
            return _balance; 
        }
    }
}
