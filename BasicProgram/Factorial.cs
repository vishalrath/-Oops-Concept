using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Factorial
    {
        public void factor()
        {
            int n;
            int fact = 1;
            Console.Write("Enter the number :");
            n = Convert.ToInt32(Console.ReadLine());
            for(int  i=1;i<=n;i++)
            {
                fact = fact * i;
                Console.WriteLine("factor is :" + fact);
            }

        }
    }
}
