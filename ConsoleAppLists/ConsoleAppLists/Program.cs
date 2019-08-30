using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Courses = new List<string>();
            Courses.Add("C#");
            Courses.Add("HTML5");
            Courses.Add("Database");
            Courses.Add("Java");
            Courses.Add("SQL");
            Courses.Add("MySQL");
            Courses.Add("Javascript");

            if (Courses.IndexOf("C#") != -1)
            {
                //C# Class exist in our list , perform necessary operations
            }

           // Console.WriteLine(Courses.IndexOf("HTML5"));
          //  Console.ReadLine();

           // Courses.RemoveAt(Courses.IndexOf("C#"));
            // or Courses.RemoveAt(0);


          //  Console.WriteLine(Courses.IndexOf("HTML5"));
           // Console.ReadLine();

            foreach(var item in Courses)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();


            Courses.Sort();


            foreach (var item in Courses)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();


            List<Students> mystudents = new List<Students>();

            Students objStudent = new Students();

            objStudent.FirstName = "Han";
            objStudent.LastName = "Solo";
            objStudent.Enrolled = "yes";



            mystudents.Add(objStudent);


            IDictionary<int, string> dictCourses = new Dictionary<int, string>();


            dictCourses.Add(101, "C#");
            dictCourses.Add(102, "HTML");
            dictCourses.Add(201, "Java");

            foreach (KeyValuePair<int,string> item in dictCourses)
            {
                Console.WriteLine("Key: {0}, Value:  {1}", item.Key, item.Value);

            }
            Console.ReadLine();



        }
    }
}
