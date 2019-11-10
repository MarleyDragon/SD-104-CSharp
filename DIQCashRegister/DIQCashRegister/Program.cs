using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIQCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price + 1, (int)price + rnd.Next(1,5));
                decimal change = (tendered - price);
                Console.WriteLine("The price is "+ price);
                Console.WriteLine("The cash tendered is  " +tendered);
                Console.WriteLine("Amount of change is " +change);
                MakeChange(change);
                
                Console.Write("\nType x to stop ");
                exit = Console.ReadLine();
            }


            //Console.WriteLine("Total Transaction amount: ");
           // tendered = Console.ReadLine();


        }
       public static void MakeChange(decimal change)
        {

            var coins = new[]
            {
                new{name ="dollar", nominal =1.00m},
                new {name ="quarter", nominal =0.25m},
                new{name ="dime", nominal =0.10m},
                new{name ="nickel", nominal =0.05m},
                new{name ="cent", nominal =0.01m},

            };
            Console.WriteLine("Change due:");
            foreach (var coin in coins)
            {
                int count = (int)(change / coin.nominal);
              
                change -= (count * coin.nominal);

                              
                if (count>1)
                {
                    Console.Write( count +" "+ coin.name + "s, ");
                }
                else
                {
                    Console.Write(count + " " + coin.name+ ", " );
                }


            }

            
            
        }
        


       
         
        

        



        
    }
}
