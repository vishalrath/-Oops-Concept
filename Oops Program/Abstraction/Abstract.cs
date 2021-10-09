using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    abstract class Abstract    //Abstract class it is not create to obj
    {
        public string FirstName;
        public string LastName;
        public int age;
        public string PhoneNumber;

        public abstract void PrintDetails();     // create abstract method using abstract keyword
                                                 //its doesnt build implimentaion body
    }
}
