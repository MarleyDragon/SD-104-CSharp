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
            Console.WriteLine("the average of array1 is "+avg);
            Console.ReadLine();

            Console.WriteLine("_______________________________________________");
            /*  Use Console.WriteLine to
  display the length of a string
  display the string upper-cased
  split a string into an array of individual words then print the words using a loop
  display the last character of a string
  display the 5th character of a string
  display the first 5 characters of a string
  display the last 5 characters of a string
  display characters 5 through 8(the fifth character and the next 3)
  display a new string afer replacing all of the spaces with the underscore character
  does the string contain a word of your choosing. */

            string userString;

            Console.WriteLine("Type a Sentance: ");
            userString = Console.ReadLine();
            Console.WriteLine("~            ~~~~~~~~~~~~~~                 ~");
            int strLength = userString.Length;
            Console.WriteLine("String length is " + strLength);
            Console.WriteLine("~            ~~~~~~~~~~~~~~~~                ~");
            Console.WriteLine(userString.ToUpper());

            Console.WriteLine("~         ~~~~~~~~~~~~~~~~~~~~~~~~              ~");


            string source = userString;
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] result;
Console.WriteLine("~   ~~        ~~~~~~~~~~~~~~         ~~          ~");
            Console.WriteLine("The fifth character of the string is '"+userString[5] + "'");
            string str = userString.Substring(userString.Length - 5);
            Console.WriteLine("The last 5 characters of the string is '" + str + "'");
            Console.WriteLine("~   ~~        ~~~~~~~~~~~~~~         ~~          ~");
            string str2 = userString.Substring(userString.Length - 1);
            Console.WriteLine("The last character of the string is '"+str2 + "'");
            Console.WriteLine("~   ~~        ~~~~~~~~~~~~~~         ~~          ~");
            Console.WriteLine("The fifth to eighth character of the string is '" + userString.Substring(5,3)+"'");

            Console.WriteLine("~   ~~        ~~~~~~~~~~~~~~         ~~          ~");
            Console.WriteLine("Splitting the string:\n   \"{0}\".", source);
            Console.WriteLine();
            Console.WriteLine("Using the delimiter string:\n   \"{0}\"",
                              separators[0]);
            Console.WriteLine();
            
            result = source.Split(separators,
                      StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Result including non-empty elements ({0} elements):",
                              result.Length);
            Console.Write("   ");
            foreach (string s in result)
            {
                Console.WriteLine("'{0}' ", String.IsNullOrEmpty(s) ? "<>" : s );
                
            }
            Console.WriteLine();

            Console.WriteLine("~   ~~        ~~~~~~~~~~~~~~         ~~          ~");
            Console.WriteLine(userString.Replace(' ', '_'));

            Console.WriteLine("~   ~~        ~~~~~~~~~~~~~~         ~~          ~");
            Console.WriteLine("Type a word to see if your string has a specified word.");
            bool hasWord = userString.Contains(Console.ReadLine());
            Console.WriteLine("Does it? " + (hasWord ? "Why yes is does!" : "No it does not."));

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



