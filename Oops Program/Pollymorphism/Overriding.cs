﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    class Overriding
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }

    }
    class Dog: Overriding
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
}
