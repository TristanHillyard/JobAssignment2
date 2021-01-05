using System;
using System.Collections.Generic;

namespace JobAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.firstName = "Sample ";
            employee.lastName = "Student";
            employee.EmployeeId = 1;
            employee.SayName();
            employee.Quit();

            Employee<string> employee1 = new Employee<string>();
            employee.firstName = "Tristan ";
            employee.lastName = "Hillyard";
            employee.EmployeeId = 2;
            employee.SayName();
            Console.WriteLine(employee.EmployeeId == employee1.EmployeeId);

            Employee<string> employee2 = new Employee<string>();
            employee2.Things.Add("Joe");
            employee2.Things.Add("Jim");
            

            Employee<int> employee3 = new Employee<int>();
            employee3.Things.Add(1);
            employee3.Things.Add(2);

            for (int i =0; i < employee2.Things.Count; i++)
            {
                employee2.
            }


        }
    }
}
