using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    class CheckingAccount:Account

    {
        /// <summary>
        /// Inherited from Account class
        /// this is Child Class
        /// </summary>
        /// <param name="initialBalance"></param>
        public CheckingAccount(decimal initialBalance):base(initialBalance)
        {

        }

        public Transaction Withdrawal(decimal amount)
        {
            Transaction thisTransaction = new Transaction();
            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.isSuccessful = false;
            thisTransaction.TimeStamp = DateTime.Now;


            if (amount > Balance)
            {
                thisTransaction.Detail = "Insufficient funds.";
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = String.Format("Account#: {0} was debited {1}.", thisTransaction.AccountNumber, thisTransaction.Amount);

            }
            return thisTransaction;
        }
        



    }
}
