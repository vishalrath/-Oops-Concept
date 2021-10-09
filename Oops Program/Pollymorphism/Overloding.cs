using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    class Overloding
    {
         public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
         public void Sum(float a, int b)
        {
            Console.WriteLine(a + b );
        }
        public void Sum(int a, float b)
        {
            Console.WriteLine(a + b);
        }
    }
}
