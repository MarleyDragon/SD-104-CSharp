using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // for each multiple of 3 print fizz

            //for each multiple of 5 print fizz

            //for multiples of both print fizzbuzz

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                                               
            }
            Console.ReadLine();
        }
    }
}
