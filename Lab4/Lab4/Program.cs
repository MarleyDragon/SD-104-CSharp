using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            string strEntry;
                int nCurrent;
                int nSmallest;
                int nLargest;





                Console.WriteLine("Enter an integer: ");
                nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());
                       
                Console.WriteLine("Enter another integer or Q to Quit: ");
               strEntry=Console.ReadLine();



            while(strEntry != "Q")
                {
                    nCurrent =Convert.ToInt32(strEntry);

                if(nCurrent>nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent<nSmallest)
                {
                    nSmallest = nCurrent;
                }

                Console.WriteLine("Enter another integer or Q to Quit: ");
                strEntry = Console.ReadLine();

                }
                

                Console.WriteLine("Smallest number you entered was " + nSmallest+".");
                Console.WriteLine("Largest number you entered was " + nLargest + ".");
                Console.ReadLine();


            }
        }
    }


