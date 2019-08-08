using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the sequence number of Fibonacci: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " \r\n");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();


            }
    }
}
