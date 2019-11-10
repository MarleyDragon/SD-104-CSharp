using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden, num;
            string answer;
            {
                hidden = rand.Next(100);
                //Console.WriteLine(hidden);
                // ask user for a number
                // keep guessing until they guess the number
            }
            do
            {
                Console.WriteLine("Guess the number between 1 and 100: ");
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



                if (num == hidden)
                {
                    Console.WriteLine(num + " is the Correct Answer! You Won! Finally.... ^(^-^)>");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Try again? Type Y for yes, any other character to give up");
                    answer= Console.ReadLine();
                    if (answer is "Y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("The number was " + hidden + ".... (T-T)");
                        Console.ReadLine();
                        break;
                                            
                    }
                }



            }
            while (true);
            


           
        }
        

           
        }
    }

