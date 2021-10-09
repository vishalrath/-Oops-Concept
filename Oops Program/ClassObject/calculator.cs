using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
   public class calculator
    {
       
        public int num1; //Declaration data type
        public int num2;
        int Result;

         public void Add() //creating and declaire method Add
        {
            Result = num1 + num2;
            Console.WriteLine("Addition is :" + Result);
            Console.ReadLine();   //Stop the terminal screen
        }
        public void sub()    // creating and declaire method Add
        {
            Result = num1 - num2;
         
            Console.WriteLine("Substraction is :" + Result);
            Console.ReadLine();

        }
    }
}
