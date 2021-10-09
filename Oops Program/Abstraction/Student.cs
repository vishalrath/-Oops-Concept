using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    class Student: Abstract       //inherit toAbstract class to child class
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()       //Abstract class override to child class so using method overrid keyword
        {
            String name = this.FirstName + "" + this.LastName;
            Console.WriteLine("Student Name is: {0}", name);
            Console.WriteLine("Student PhoneNumber is: {0}", this.PhoneNumber);
            Console.WriteLine("Student Age is: {0}", this.age);
            Console.WriteLine("Student Roll Number is: {0}", this.RollNo);
            Console.WriteLine("Student Fees is: {0}", this.Fees);
            Console.WriteLine();


        }
    }
}
