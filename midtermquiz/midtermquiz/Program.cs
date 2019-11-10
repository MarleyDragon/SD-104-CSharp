using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string meal;

            
                Console.WriteLine("What meal do you want to consume? (Breakfast, Brunch, Lunch, Snack, Dinner, or Dessert).");
           

            do
            {  meal = Console.ReadLine();

                switch (meal.ToLower())
                {
                    case "breakfast":
                        Console.WriteLine("Breakfast should be eaten between the hours of 6am to 8am.");
                        Console.ReadLine();
                        break;
                    case "brunch":
                        Console.WriteLine("Brunch should be eaten between the hours of 9am to 10am.");
                        Console.ReadLine();
                        break;
                    case "lunch":
                        Console.WriteLine("Lunch should be eaten between the hours of 11am to 1pm.");
                        Console.ReadLine();
                        break;
                    case "snack":
                        Console.WriteLine("Snacks should be eaten between the hours of 3pm to 4pm.");
                        Console.ReadLine();
                        break;
                    case "dinner":
                        Console.WriteLine("Dinner should be eaten between the hours of 5pm to 7pm.");
                        Console.ReadLine();
                        break;
                    case "dessert":
                        Console.WriteLine("Dessert should be eaten between the hours of 7pm to 8pm.");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Please choose a meal.");
                        break;

                }
                Console.WriteLine("Type another meal.");
                
            } while (true);
        }
    }
}
