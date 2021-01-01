using System;

namespace JobAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.EmployeeId = 1;
            employee.SayName();
            employee.Quit();

            Employee employee1 = new Employee();
            employee.firstName = "Tristan";
            employee.lastName = "Hillyard";
            employee.EmployeeId = 2;
            employee.SayName();
            Console.WriteLine(employee.EmployeeId == employee1.EmployeeId);
        }
    }
}
