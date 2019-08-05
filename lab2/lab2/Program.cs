using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {                       /*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

            //prompt for name and receive
            string strPlayerName;
            double dblHits, dblAtBats;
            double dblBattingAverage;
            Console.WriteLine("This program calculates a baseball player's batting average~");
            Console.WriteLine("<------------------------------------------>~");
            Console.WriteLine("");
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();

            //prompt for hits
            Console.WriteLine("Enter the player's number of hits: ");
            dblHits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the player's number of  at bats: ");
            dblAtBats = Convert.ToInt32(Console.ReadLine());

            dblBattingAverage = dblHits / dblAtBats;
            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();

        }
    }
}
