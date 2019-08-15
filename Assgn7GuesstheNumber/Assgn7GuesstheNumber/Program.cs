using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn7GuesstheNumber
{
    class Program
    {

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void Main(string[] args)
        {
            int num;

            do
            {
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

                if (num == )
                {

                }


            } while (true);
        }

    }
}
