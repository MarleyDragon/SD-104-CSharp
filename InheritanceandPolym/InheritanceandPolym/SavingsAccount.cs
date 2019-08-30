using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    class SavingsAccount : Account
    {

        private const int MONTHLY_WITHDRAWAL_LIMIT = 5; //private constants are usually written in all caps



        public decimal InterestRate { get; set; }

        public int WithdrawalsThisMonth{get; set; }

        public SavingsAccount(decimal intialBalance, int withdrawalsThisMonth):base(intialBalance)
        {
            WithdrawalsThisMonth = withdrawalsThisMonth;

        }

        public override Transaction Withdrawal(decimal amount)
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
            else if (WithdrawalsThisMonth > MONTHLY_WITHDRAWAL_LIMIT)
            {
                thisTransaction.Detail = "Transaction failed: Past monthly limit of withdrawals.";
                Console.WriteLine("Transaction failed: Past monthly limit of withdrawals.");
            }
            else
            {
                Balance -= amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = String.Format("Account#: {0} was debited {1}.", thisTransaction.AccountNumber, thisTransaction.Amount);
                Console.WriteLine(thisTransaction.Detail);


            }
            return thisTransaction;

        }

        public void ProcessDividends()
        {
            Balance += Balance * InterestRate;
        }

    }
}
