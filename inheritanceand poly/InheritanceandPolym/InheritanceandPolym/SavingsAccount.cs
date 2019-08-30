using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    class SavingsAccount : Account
    {

        private const int MONTHLY_WITHDRAWAL_LIMIT = 5;


        public decimal InterestRate { get; set; }

        public int WithdrawalsThisMonth{get; set; }

        public SavingsAccount(decimal intialBalance, int withdrawalsThisMonth):base(intialBalance)
        {
            WithdrawalsThisMonth = withdrawalsThisMonth;

        }
    }
}
