using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class evenodd
    {
        public void oddeven()
        {
            int number; 
            int Remainder;
            Console.Write("Enter the number :");
            number = Convert.ToInt32(Console.ReadLine());

            Remainder = number % 2;
            if (Remainder==0)
            {
                Console.WriteLine("number is even:" + number);

            }
            else
            {
                Console.WriteLine("number is odd:" + number);
            }
        }
    }
}
