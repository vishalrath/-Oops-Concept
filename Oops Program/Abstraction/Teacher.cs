using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    class Teacher:Abstract
    {
        public string Qualification;
        public int Salary;

        public override void PrintDetails()        //Abstract class override to child class so using method overrid keyword
        {
            String name = this.FirstName + "" + this.LastName;
            Console.WriteLine("Teacher Name is: {0}", name);
            Console.WriteLine("Teacher PhoneNumber is: {0}", this.PhoneNumber);
            Console.WriteLine("Teacher Age is: {0}", this.age);
            Console.WriteLine("Teacher Qualification is: {0}", this.Qualification);
            Console.WriteLine("Teacher Salary is: {0}", this.Salary);
            Console.WriteLine();
        }
    }
}
