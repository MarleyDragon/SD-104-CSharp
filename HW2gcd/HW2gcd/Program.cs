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
            int nMin=0;
            int nMax=0;


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
            if (n1 < n2)
            {
                
               nMin=n1;
               nMax=n2;
                        

            }
            else
            {
                nMax = n1;
                nMin = n2;
            }

            

                n3 = nMax % nMin;

                Console.WriteLine("The greatest common divisor between " + nMax + " and " + nMin);
                do
                {
                    if (n3 == 0)
                    {
                        Console.WriteLine("is " + nMax + ".");
                        break;
                    }
                    else
                    {
                        n3 = nMax % nMin;

                    nMax = nMin;
                    nMin = n3;

                    }


                }
                while (n3 >= 0);


            




            Console.ReadLine();
        }
    }
}
