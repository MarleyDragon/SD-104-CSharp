using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stream myStream;
            // myStream = null;


            //Step 1

            FileStream myFileStream = new FileStream("TextFile1.txt", FileMode.Open, FileAccess.Read);

            //step 2

            StreamReader myFileReader = new StreamReader(myFileStream);

            //Step 3

            Console.WriteLine(myFileReader.ReadLine());
            Console.ReadLine();


        }


    }
}
