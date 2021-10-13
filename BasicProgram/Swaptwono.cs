using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Swaptwono
    {
        public void swapno()
        {
            int a;
            int b;
            Console.WriteLine("enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swap a= " + a + " b= " + b);


        }
    }
}
