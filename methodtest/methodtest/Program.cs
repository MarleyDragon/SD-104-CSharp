using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            Sing();
            CalculateAvg(587, 6);

        }
        static void SayHi()
        {
            Console.WriteLine("Hello Christopher");
            Console.ReadLine();

        }
        static void Sing()
        {
            Console.WriteLine("My shadow's the only one that walks beside me...");
            Console.ReadLine(); 
        }
       static void CalculateAvg(int x, int y)
        {
            
            Console.WriteLine(x/y);

        }
            

    }
}
