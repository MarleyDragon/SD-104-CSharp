using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallHW4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Prove that Ben is correct by writing a program that simulates the Monty Hall Game Show 10,000 times in a For loop. 
            Simulate random placement of the car behind one of the three doors (hint: use a List or array of type bool so you 
            can cycle through them).  Do the same for the player's selection.  Be careful, with the Random.Next() function.  
            It is actually pseudorandom based on the system clock.  If you have the code pick two random numbers back to back, 
            they will most likely be the same random number.  You could just have the player pick the same door every time or 
            use the loop count % 3.  You can decide whether to switch based on whether the loop count is odd or even (modulus 2).  
            Keep track of whether the player won or lost and whether they switched to get that win or loss.  You can display every
            round if you like but ultimately just show the number of times won when the player switched doors and the number of times
            they won when they didn't switch.  You should find a distribution where the number of times won when switching is 2 times 
            more than the number of times won when not switching doors (+/-3333 to +/-1666). */



                Game one = new Game();

                one.PlayGame();


            Console.WriteLine(nRand);


        }

            
        



    }

    
        

           

        
    }


