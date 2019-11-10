using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        /*static void Main(string[] args)
        {
            //Fibonacci, writes entire sequence to the nth number (gets wonky after 47th postition)
            /* int n1 = 0, n2 = 1, n3, i, number;
             Console.Write("Enter the sequence number of Fibonacci: ");
             number = Convert.ToInt32(Console.ReadLine());
             Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
             for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
             {
                 n3 = n1 + n2;
                 Console.Write(n3 + " \r\n");
                 n1 = n2;
                 n2 = n3;

             }*/
        class fibonacci
        {

            static int Fib(int n)
            {

                // Declare an array to  
                // store Fibonacci numbers. 
                // 1 extra to handle  
                // case, n = 0 
                int[] f = new int[n + 2];
                int i;

                /* 0th and 1st number of the  
                   series are 0 and 1 */
                f[0] = 0;
                f[1] = 1;

                for (i = 2; i <= n; i++)
                {
                    /* Add the previous 2 numbers 
                       in the series and store it */
                    f[i] = f[i - 1] + f[i - 2];
                }

                return f[n];
            }

            // Driver Code 
            public static void Main()
            {
                int n = 0;
                Console.Write("Enter the sequence number of Fibonacci: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fib(n));
                Console.ReadLine();
            }


        }
    }
}
    
        
    
            


            
    

