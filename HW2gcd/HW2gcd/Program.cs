using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2gcd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;


            Console.WriteLine("Enter an integer: ");
            while (Int32.TryParse(Console.ReadLine(), out n1) == false)
            {
                Console.WriteLine("Not Valid. Must be a Positive rational number");
            }

            Console.WriteLine("Enter another integer or Q to Quit: ");
            while (!int.TryParse(Console.ReadLine(), out n2) || n2 < 0)
            {
                Console.WriteLine("Not Valid. Must be a Positive rational number");
            }

            n3 = n1 % n2;
            Console.WriteLine(n3);

            do
            {
                if (n3 > 0)
                {
                    n3 = n1 % n2;
                    Console.Write("Remainder is " + n3 + ".\r\n");
                    n1 = n2;
                    n2 = n3;
                }
                else if (n3 == 0)
                {
                    Console.WriteLine("Greatest common divisor is " + n2);
                }

            }
            while (n3 != 0);






            Console.ReadLine();
        }
    }
}
