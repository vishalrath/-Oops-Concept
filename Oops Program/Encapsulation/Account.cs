using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    class Account
    {
        int accountbalance = 100;              // in the Encapsulation is datatype is privte

        /* public void SetBalance(int amount)                // Creating seter method passing parameter
         {
             if(amount < 0)
             {
                 Console.WriteLine("you are entering negetive number");
             }
             else
             {
                 accountbalance = amount;                 //Assign for value  amount to  accountbalance
             }

         }
         public void GetBalance()                              // Creating Geter method passing parameter
         {
             Console.WriteLine("your Account Balance is:" + accountbalance);
         }*/


        // using C# property

        //property means : combination of veriable and method
        // property contain two inbuild method get and set
        public int Balance                     // This is property
        {
            set                                // set method is modify and assign the value
            {
                if (value < 0)
                {
                    Console.WriteLine("you enter valid amount");
                }
                else
                {
                    accountbalance = value;
                }
            }
            get                              // get method is read and show the value
            {
                return accountbalance;
            }
        }

    }
}
