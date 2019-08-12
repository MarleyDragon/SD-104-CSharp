using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraPractice
{
    class Program

    {
        static void Main(string[] args)
        {
            int i, max, min;
           

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


            min = userArray[0];
            max = userArray[0];



            for (i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] < min)
                    min = userArray[i];

                if (userArray[i] > max)
                    max = userArray[i];
            }



            Console.WriteLine("Your Minimum number is: " + min);

            Console.WriteLine("Your Maximum number is: " + max);


            Console.Read();
        }
    }
}

