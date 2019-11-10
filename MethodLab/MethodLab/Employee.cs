using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLab
{
    class Employee
    {
         string firstName;
         string lastName;
         string dept;


        public Employee(string firstName, string lastName, string dept)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;


            if (string.IsNullOrEmpty(dept))
            {

                dept = "IT";
            }

            Console.WriteLine(firstName + " " + lastName + " is in " + dept);
            Console.ReadLine();


        }


        
    }
}
