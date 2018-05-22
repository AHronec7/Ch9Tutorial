using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        // field 

        private decimal _balance;

        public Account(decimal startbalance)
        {
            _balance = startbalance;
        }

        // balance property

        public decimal Balance
        {
            get { return _balance; }
        }

         
        // deposit method 

        public void deposit (decimal amount)
        {
            _balance += amount;
        }

        // withdrawal mehtod

        public void withdrawal(decimal amount)
        {
            _balance -= amount;
        }

    }
}
