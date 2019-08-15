using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLab
{
    class Program
    {
        class Employee
        {
            public string FirstName;
            public string LastName;
            public string Dept;

            public void SetNames()
                {
                //blah
                }
        }
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();

            myEmployee.FirstName = "Taylor";
            myEmployee.LastName = "Amazon";
            myEmployee.Dept = null;


            myEmployee.SetNames();
            AssignDept(myEmployee);

            Console.WriteLine(myEmployee.Dept);
            Console.ReadLine();


    
        }

      
        static void AssignDept (Employee emp)
        {
            if (string.IsNullOrEmpty(emp.Dept))
            {
                emp.Dept = "Sales";
            }
            
        }
    }
}
