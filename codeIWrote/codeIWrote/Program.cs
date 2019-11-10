using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIWrote
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creating variables and changing their values
Using IF statements to control the flow of the application
Using a SWITCH statement to chose a path based on the value of a variable
Using a FOR, DO-WHILE or WHILE loops to do anything. Just print the numbers between 1 and 100.
Creating simple arrays and looping through the array and printing the contents.
*/

            Random rand = new Random();
            int brawn, speed, wit, spirit, finesse, num;
            string answer;
            {
                brawn = rand.Next(1,6);
                speed = rand.Next(1, 6);
                spirit = rand.Next(1, 6);
                finesse = rand.Next(1, 6);
                wit = rand.Next(1, 6);
                Console.WriteLine("Your Brawn is "+ brawn);
                Console.WriteLine("Your Spirit is " + spirit);
                Console.WriteLine("Your Speed is " + speed);
                Console.WriteLine("Your Finesse is " + wit);
                Console.WriteLine("Your Wit is " + finesse );
                Console.ReadLine();
            }

            switch
                Case Fighter: 
                {
                Console.WriteLine("You are a fighter!");

            }



        }
    }
}
