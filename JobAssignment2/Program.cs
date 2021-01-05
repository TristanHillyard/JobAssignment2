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

            foreach(string item in employee2)
            {
                Console.WriteLine(item);
            }

            foreach(int item in employee3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
