using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
             string sVal;
            int iVal;

            sVal = "this is a string";
            iVal = int.Parse("23");
            // comment
            /* longer
             * comments
             * 
             */
            int x = 100;
            int y = -87;
            int z;

            /* after this next line of code z will have the value of x and y added together. 
                in this case that would be 100 + -87. The value of z would be 13.
                two things are happening here. 
               1) We are adding two variables together
                2) and Assigning them to a third
                */
            z = x + y;
            Console.WriteLine(z);
            z = z + 10;   
            // now we are increasing z by 10. z will have 10 added to it, making it now 23
            Console.WriteLine(z);

            double iScoreHits;
            double iMatchesBat;
            double iAvgStat;

            iAvgStat = iScoreHits / iMatchesBat;

            Console.WriteLine("The Matrix Has you..");
            Console.WriteLine("I paid {0:C} for her.", 20);
          

            Console.ReadLine();
            
        }
    }
}
