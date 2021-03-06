﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JobAssignment2
{
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things = new List<T>();
        public int EmployeeId { get; set; }

        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine(firstName + lastName + " quits");
        }
        public static bool operator ==(Employee<T> employee, Employee<T> employee1)
        {
            if (employee.EmployeeId == employee1.EmployeeId)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee<T> employee, Employee<T> employee1)
        {
            if (employee.EmployeeId == employee1.EmployeeId)
                return false;
            else
                return true;
        }
    }
}
