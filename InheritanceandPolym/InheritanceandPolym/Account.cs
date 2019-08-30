using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    abstract class Account
    {
        ///
        /// 
        ///Parent Class
        

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

        /// <summary>
        /// child class can implement its own withdrawal method with custom logic
        /// </summary>
        /// 
        public abstract Transaction Withdrawal(decimal amount);

    }
}
