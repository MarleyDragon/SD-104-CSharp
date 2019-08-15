using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ans = 5, v1 = 2, v2 = 10, v3 = 18;
            //ans += v1 + 10 * (v2-- / 5) + v3 / v2;
            //Console.WriteLine(ans);
            // Console.ReadLine();
            // ans += v1 + v2 * v3 % 2;
            // Console.WriteLine(ans);
            // Console.ReadLine();

            int sum = 0;
            int number = 1;
            while (number < 100)
            {
                sum = sum + number;
                Console.WriteLine(sum);
            
            }
            
            Console.ReadLine();
        }
    }
}
