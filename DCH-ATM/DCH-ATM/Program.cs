using System;
using System.Collections.Generic;

namespace DCH_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance, amount, choice;
            string accountName;
            int menuOption = 0;
            Checking checking = null;
            Savings savings = null;
            string answer;
            do
            {

                while (menuOption != 1)
                {
                    menuOption = GetNumber(
                        "Choose a Menu option. **Must create account first**\n" +
                        "1 - Exit\n" +
                        "2 - Create Checking\n" +
                        "3 - Create Savings\n" +
                        "4 - Checking Balance\n" +
                        "5 - Savings Balance \n" +
                        "6 - Make a deposit\n" +
                        "7 - Transfer Money\n");
                    switch (menuOption)
                    {
                        //  exit the ATM
                        case 1:
                            Environment.Exit(0); 
                            break;

                        case 2:
                            accountName = GetInput("Account Name: ");
                            balance = GetNumber("Initial Amt: ");
                            checking = new Checking(accountName, balance, 0.02f);
                            Console.WriteLine("Your " + checking.AccountName + " balance is " + checking);
                            break;

                        case 3:
                            accountName = GetInput("Account Name: ");
                            balance = GetNumber("Initial Amt: ");
                            savings = new Savings(accountName, balance, 0.03f);
                            Console.WriteLine("Your " + savings.AccountName + " balance is " + savings);
                            break;

                       case 4:

                            Console.WriteLine("Your " + checking.AccountName + " balance is " + checking.Balance);

                            break;
                        case 5:
                            Console.WriteLine("Your " + savings.AccountName + " balance is " + savings.Balance);

                            break;
                        case 6:
                            Console.WriteLine("Into checkings, press C; into savings, press S.");
                            answer = Console.ReadLine();
                            if (answer is "C" ||answer is "c")
                            {
                             amount = GetNumber("Deposit Amount: ");
                                checking.Deposit(amount);
                                Console.WriteLine("Your " + checking.AccountName + " balance is " + checking);
                                break;
                           
                            }
                            else
                            {
                                amount = GetNumber("Deposit Amount: ");
                                savings.Deposit(amount);
                                Console.WriteLine("Your " + savings.AccountName + " balance is " + savings);
                                break;
                            }
                            

                        case 7:
                            {                              

                                choice = GetNumber("To transfer from Savings to Checking, press 1.\n" +
                                    "To transfer from Checking to Savings, press 2. \n");
                                
                                if (choice == 1)
                                {
                                    Console.WriteLine("Your "+ savings.AccountName +" balance is "+ savings.Balance);
                                    amount = GetNumber("Amount that you wish to transfer from savings: ");
                                    savings.Withdrawal(amount);
                                    checking.Deposit(amount);

                                    break;

                                }
                                else if(choice == 2)
                                {
                                    Console.WriteLine("Your "+ checking.AccountName +" balance is " + checking.Balance);
                                    amount = GetNumber("Amount that you wish to transfer from checking: \n" +
                                        "Remember, there will be a $1 transaction fee to withdraw from checking.\n");
                                    checking.Withdrawal(amount);
                                    savings.Deposit(amount);
                                    break;
                                }
                                else
                                {
                                    break;
                                }

                            }



                        default:
                            break;
                    }
                    //Console.WriteLine("Your " + savings.AccountName + " balance is " + savings);
                    //Console.WriteLine("Your " + checking.AccountName + " balance is " + checking); 
                }
            } while (true); 
        }   // end of the Main method. Everything comes after here

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }   // end of the GetInput method
        
        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }   // end of the GetNumber method
    }
}
