using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIWrote
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int brawn, speed, wit, spirit, finesse, num;
            string answer;
            {
                brawn = rand.Next(1,6);
                speed = rand.Next(1, 6);
                spirit = rand.Next(1, 6);
                finesse = rand.Next(1, 6);
                wit = rand.Next(1, 6);
                Console.WriteLine("Your Brawn is "+ brawn);
                Console.WriteLine("Your Spirit is " + spirit);
                Console.WriteLine("Your Speed is " + speed);
                Console.WriteLine("Your Finesse is " + wit);
                Console.WriteLine("Your Wit is " + finesse );
                Console.ReadLine();


            }
        }
    }
}
