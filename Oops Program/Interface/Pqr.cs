using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    interface IAdd
    {
         int sum(int x, int y);
         int mul(int x, int y);
     }
     public  class Pqr: IAdd
    {
         public int sum (int x, int y)
         {
               return (x + y);
             //Console.WriteLine("sum is:"+(x + y));
         }
         public int mul(int x, int y) 
         {
             return (x * y);
             //Console.WriteLine("mul is:" + (x + y));
         }

     }
}
