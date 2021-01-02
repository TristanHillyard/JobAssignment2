using System;

namespace JobAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.firstName = "Sample";
            //employee.lastName = "Student";
            //employee.EmployeeId = 1;
            //employee.SayName();
            //employee.Quit();

            //Employee employee1 = new Employee();
            //employee.firstName = "Tristan";
            //employee.lastName = "Hillyard";
            //employee.EmployeeId = 2;
            //employee.SayName();
            //Console.WriteLine(employee.EmployeeId == employee1.EmployeeId);
            
            Employee<string> employee = new Employee<string>();
            employee.Things.Add("Joe");
            employee.Things.Equals("Joe");

            employee.Things.Add("Jim");
            
            Employee<int> employee1 = new Employee<int>();
            employee1.Things.Add(1);
            employee1.Things.Add(2);

            for(int i = 0; i < employee.Things.Count; i++)
            {
                Console.WriteLine(employee.Things);
            }
            for(int i = 0; i < employee1.Things.Count; i++)
            {
                Console.WriteLine(employee1.Things);
            }
            
                
        }
    }
}
