using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn7GuesstheNumber
{
    class Program
    {

        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void Main(string[] args)
        {
            int num; int R = RandomNumber(1, 100);

            int count = 0;

            do
            {
                count++;
                Console.WriteLine("Hey You! Give me a number! ");
                int.TryParse(Console.ReadLine(), out num);
                do
                {


                    if (num > 100)
                    {
                        Console.WriteLine("Can you read?? It say's a number between 1 and 100!! <(-_-)> ");
                        break;
                    }
                    else if (num > 0)
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("I need a NUMBER! <(<-_-*)");
                        break;
                    }
                } while (true);
                do
                {
                    if (num == R)
                    {
                        Console.WriteLine("Congrats! You win!!");
                        break;
                    }
                    else if (num > R)
                    {
                        Console.WriteLine("Oh no! Your number is too high!");
                        break;
                    }
                    else if (num < R)
                    {
                        Console.WriteLine("oh no! Your Number is too low");
                        break;

                    }

                } while (true);

            } while (true);
            
          
            Console.WriteLine("well done you took " + count + " times to guess the number.");
            //add number of guesses..?

        }


        

    }
}
