﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssignment2
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
