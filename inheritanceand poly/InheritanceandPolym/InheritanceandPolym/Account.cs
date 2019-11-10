using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    class Account
    {

        ///Parent Class: Inheritance
        

        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
