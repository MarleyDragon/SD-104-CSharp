using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraPractice
{
    class Program2

    {
        static void Main(string[] args)
        {
            int i;
           

            Console.Write("Please enter how many numbers you want in your array: ");
            int input;
            

            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.Write("Not a number. Please enter a number: ");
            }
            int[] userArray = new int[input];
            for (i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Please enter the value for number " + (i + 1) + ":");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.Write("Not a number. Please enter a number: ");
                }
                userArray[i] = input;
            }


            Console.WriteLine("Your array backwards is: ");
            Console.WriteLine("-------------------------");

            for (int count = userArray.Length - 1; count >= 0; count--)
            {
                if (count != 0)
                {
                    Console.Write(userArray[count] + " , ");
                }
                else
                {
                    Console.Write(userArray[count]);
                }
            }

            Console.Read();
        }
    }
}

