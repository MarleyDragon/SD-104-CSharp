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

            int max1 = FindMax(array1);
            Console.WriteLine("The max number of array 1 is "+max1);

            int max2 = FindMax(array2);
            Console.WriteLine("The max number of array 2 is " + max2);

            Console.ReadLine();

            Console.WriteLine(" ______________________________________");

            Console.WriteLine("What is the temperature?");
            float temp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Press C to convert from Celsius to Fahrenheit;\n" +
                " or F to convert from Fahrenheit to Celsius:");
            string tempType = Console.ReadLine();
            float convertedTemp = ConvertTemp(tempType, temp);
            Console.ReadLine();

            Console.WriteLine(" ______________________________________");

            float avg = FindAverage(array1);
            Console.WriteLine(avg);
            Console.ReadLine();


        }


        static float FindAverage(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {


                sum += array[i];

            }
            float avg = sum / array.Length;
            return avg;
        }
        static int FindMax(int[] array)
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
        static float ConvertTemp(string tempType, float temp)
        {
            if (tempType== "C" || tempType== "c")
            {
                temp = ((temp * 9) / 5) + 32;
                Console.WriteLine(temp);
            }
            else if (tempType == "F" || tempType == "f")
            {
                temp = ((temp - 32) * 5) / 9;
                Console.WriteLine(temp);
                

            }
            return temp;
        }



    }






    
}



