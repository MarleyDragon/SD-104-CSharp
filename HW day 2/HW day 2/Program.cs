using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int smallest =0;
            int largest=0;





            Console.WriteLine("Give first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if(x>y)
            {
                Console.WriteLine(x + " is the larger number.");
                smallest = y;
                largest = x;
            }
            else if(y>x)
            {
                Console.WriteLine(y+ " is the larger number.");
                smallest = x;
                largest = y;
            }
            else
            {
                Console.WriteLine("inconclusive");
            }
            Console.ReadLine();


            Console.WriteLine("Give third number: ");
            z = Convert.ToInt32(Console.ReadLine());


            // Set smallest and largest
            if (z < smallest)
            {
                smallest = z;

            }
            if (z > largest)
            {
                largest = z;


            }

            Console.WriteLine("Smallest number is " + smallest);
            Console.WriteLine("Largest number is " + largest);
            Console.ReadLine();


        }
    }
}
