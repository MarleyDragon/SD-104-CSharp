using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
            int[] array2 = { -9, -7, -11, -7, -88, -5, -10 };

            int max = FindMax(array1);
            Console.WriteLine(max);
            Console.ReadLine();
            //_________________________________//
            public string[] arrayX = { "AAAAA", "BBBB", "CCC", "DD", "E" };
        public string[] arrayY = { "Texas", "New York", "Washington", "Nevada" };

        string reverse = ReverseArray(arrayX);







        }
    static string ReverseArray(string[] array);
    {
        string[] reverse= string[] array;



        return string[] reverse;
    }
static int FindMax(int[] array)
        {
         int maxInt = int.MinValue;
            foreach (var number in array)
            {
                if (number > maxInt)
                {
                maxInt = number;
                }
            }
        return maxInt;
        }
    }
}


   