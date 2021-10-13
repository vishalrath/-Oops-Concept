using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
   public class Power
    {
        int n;
        int i=1;
        public void number()
        {
            Console.Write("Enter the number :");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <=10)
            {
                Console.WriteLine(  n * i);
                i = (i + 1);

                Console.ReadLine();
            }
            
        }
      
    }
}
