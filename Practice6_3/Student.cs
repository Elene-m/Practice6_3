﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6_3
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age}");
        }
    }
}
