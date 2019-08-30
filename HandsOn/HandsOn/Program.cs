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
           public  int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
         public   int[] array2 = { -9, -7, -11, -7, -88, -5, -10 };




        }
    public static int FindMax(int[] array)
    {
        var maxInt = int.MinValue;
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
}
