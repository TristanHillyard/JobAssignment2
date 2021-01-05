using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssignment2
{
    interface IQuittable
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        void Quit()
        {
            Console.WriteLine("I {0} {1} quit", firstName, lastName);
        }
    }
}
