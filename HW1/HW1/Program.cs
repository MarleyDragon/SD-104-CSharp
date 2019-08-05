using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
       
            double nOne, nTwo;
            

            Console.WriteLine("Calculator");
            Console.WriteLine("<------------------------------------------>~");
            Console.WriteLine("");
            
            //prompt for hits
            Console.WriteLine("Enter first number: ");
            nOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            nTwo = Convert.ToInt32(Console.ReadLine());

       
            Console.WriteLine("The sum is "+ (nOne+nTwo));
            Console.WriteLine("The product is " + (nOne * nTwo));
            Console.WriteLine("The difference is " + (nOne - nTwo));
            Console.WriteLine("The quotient is " + (nOne / nTwo));

            Console.ReadLine();
        }
    }
}
