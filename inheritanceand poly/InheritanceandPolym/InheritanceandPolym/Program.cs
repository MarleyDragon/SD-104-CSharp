using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myChkAccount = new CheckingAccount(1000);

            Console.WriteLine("Intiate withdrawal of $250");
            myChkAccount.Withdrawal(250);
            Console.WriteLine("Balance is : $" + myChkAccount.Balance);

            Console.ReadLine();
            Console.WriteLine("Intiate withdrawal of $850");
            myChkAccount.Withdrawal(850);
            Console.WriteLine("Balance is : $" + myChkAccount.Balance);
            Console.ReadLine();
        }
    }
}
