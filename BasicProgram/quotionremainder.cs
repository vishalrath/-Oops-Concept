using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class quotionremainder
    {
        public void compute()
        {
            int dividend, divisor;
            Console.Write("Enter the dividend number :");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor number:");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
