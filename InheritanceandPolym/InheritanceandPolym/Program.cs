using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceandPolym
{
    class Program
    {

        /// <summary>
        /// polymorphism impletmentation
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Account myAccount;

            myAccount = new CheckingAccount(1000);
            myAccount.Withdrawal(500);
            Console.WriteLine(myAccount.GetType());

           
            SavingsAccount mySav= new SavingsAccount(2000, 2);
           mySav.Withdrawal(1500);
            mySav.InterestRate = 0.001M;
            mySav.ProcessDividends();
            Console.WriteLine(mySav.Balance);

            Console.WriteLine(myAccount.GetType());


            Console.ReadLine();


            
               

            

        }
    }
}
