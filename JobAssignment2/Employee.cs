using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssignment2
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine(firstName + lastName + "quits");
        }
    }
}
