using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Largestno
    {
        public void largnumber()
        {
            int num1,num2,num3;
            Console.WriteLine("enter three number");
              Console.WriteLine("enter First number");
            num1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter Third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("First number is largest:" + num1);
            }
            else if(num2 >=num1 && num2>=num3 )
            {
                Console.WriteLine("Second number is largest:" + num2);
            }
            else
            {
                Console.WriteLine("Third number is largest:" + num2);
            }
        }
    }
}
