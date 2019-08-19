using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassDesign
{
    class Program
    {
        static void Main(string[] args)
        {


            Dragon Kuro = new Dragon("Kuro", "Darkeness", 243, 205541);
            Kuro.PowerLevel = 0;
            Console.WriteLine(Kuro.ToString());
            Dragon Jack = new Dragon("Jack", "Water", 852, 9542);
            Jack.PowerLevel = 0;
            Console.WriteLine(Jack.ToString());
            Dragon Pyro = new Dragon("Pyro", "Fire", 120, 1562);
            Pyro.PowerLevel = 0;
            Console.WriteLine(Pyro.ToString());


            Character Lyla = new Character("Lyla Truthslayer", 5, "Shaman", 18, "were murdered by the Dragon Queen");
            Lyla.Name = "Lyla Dragonslayer";
            Console.WriteLine(Lyla.ToString());
            Stats LylaStats = new Stats(14, 12, 11, 18, 13);
            LylaStats.Brawn = 16;
            Console.WriteLine(LylaStats.ToString());


            Character John = new Character("John Smith", 6, "Smith", 18, "were murdered by the Dragon Queen");
            John.Name = "John Dragonslayer";
            Console.WriteLine(John.ToString());
            Stats JohnStats = new Stats(16, 12, 11, 12, 13);
            JohnStats.Brawn = 18;
            Console.WriteLine(JohnStats.ToString());

            Character Sierra = new Character("Sierra Longshot", 4, "Archer", 18, "were murdered by the Dragon Queen");
            Sierra.Name = "Sierra Dragonslayer";
            Console.WriteLine(Sierra.ToString());
            Stats SierraStats = new Stats(14, 12, 14, 11, 18);
            SierraStats.Brawn = 15;
            Console.WriteLine(SierraStats.ToString());


            Console.ReadLine();
        }




    }
}

