using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Passing Yards: 1 point per 25 yards.
Passing Touchdowns: 4 points.
Passing Interceptions: -2 points.
Rushing Yards: 1 point per 10 yards.
Rushing Touchdowns: 6 points.
Receptions: 1 points (only if using PPR scoring)
Receiving Yards: 1 point per 10 yards.
Receiving Touchdowns: 6 points.*/
            int passingYards, passingTouchdowns, passingInterceptions, rushingYards, rushingTouchdowns, receptions, receivingYards, receivingTouchdowns;
            float totalScore;



            Console.WriteLine("How many passing yards: ");
            int.TryParse(Console.ReadLine(), out passingYards);
            
            Console.WriteLine("How many passing touchdowns: ");
            int.TryParse(Console.ReadLine(), out passingTouchdowns);

            Console.WriteLine("How many passing interceptions: ");
            int.TryParse(Console.ReadLine(), out passingInterceptions);

            Console.WriteLine("How many rushing yards: ");
            int.TryParse(Console.ReadLine(), out rushingYards);

            Console.WriteLine("How many rushing touchdowns: ");
            int.TryParse(Console.ReadLine(), out rushingTouchdowns);

            Console.WriteLine("How many receptions: ");
            int.TryParse(Console.ReadLine(), out receptions);

            Console.WriteLine("How many receiving yards: ");
            int.TryParse(Console.ReadLine(), out receivingYards);

            Console.WriteLine("How many receiving touchdowns: ");
            int.TryParse(Console.ReadLine(), out receivingTouchdowns);

            totalScore = (passingYards / 25) + (4 * passingTouchdowns) + (rushingYards / 10) + (6 * rushingTouchdowns) + receptions + (receivingYards / 10) + (6 * receivingTouchdowns);

            Console.WriteLine("Total Score is " + totalScore);
            Console.ReadLine();



        }
    }
}
