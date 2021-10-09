using Oops_Program.ClassObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObjectce
{
    class Maruti:Ferrari        // maruti class (child class) is inherit by Ferrari class(parent class)

    {

       public float mileage;    // floting data type

        public void Printmileage()    // void method calling 
        {

            Console.WriteLine("mileage is:"+ mileage);
        
        }
        

    }
}
