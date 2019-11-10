using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblHeight;
            double dblWeight;
            double dblBMI;

            Console.WriteLine("Enter your height in inches: ");

            while(!double.TryParse(Console.ReadLine(), out dblHeight) || dblHeight <0)
                {
                Console.WriteLine("Not Valid.Must be a Positive rational number");
            }
            

            Console.WriteLine("Enter your weight in pounds: ");
            while (!double.TryParse(Console.ReadLine(), out dblWeight) || dblWeight < 0)
                {
                Console.WriteLine("Not Valid.Must be a Positive rational number");
            }
            
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

            Console.WriteLine("Your BMI is " + dblBMI);
            if(dblBMI<18.5)
            { Console.WriteLine("BMI <18.5 - Underweight");
            }
            else if(dblBMI <= 24.9)
            {
                Console.WriteLine("BMI is between 18.5 and 24.9 - Normal");
            }
            else if(dblBMI <=29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9- overweight");
            }
            else
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }
            Console.ReadLine();
        }
    }
    }
    
