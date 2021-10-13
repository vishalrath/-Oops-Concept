using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" please enter the number to choose");
            Console.WriteLine("1:Flipcoin\n 2:Leaf_Year\n 3:NUmber of Power\n 4:Haemonic number\n 5:Factors\n 6:Compute quotient and Remainder\n  7:Swap Two number\n 8:Check Even And Odd\n 9:vowel or consonant\n 10:find the Largest among thrre number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                 Headtail filp = new Headtail();
                    //Console.WriteLine("Let's flip a coin  times:"+ int  n);
                     filp.Coin();
                    break;

                   case 2:
                     Leafyear leaf = new Leafyear();
                     leaf.abc();
                    break;

                  case 3:
                    Power pow = new Power();
                    pow.number();
                    break;

                  case 4:
                    Harmonicnumber harmonic = new Harmonicnumber();
                    harmonic.nthHarmonic();
                    break;

                  case 5:
                    Factorial fact = new Factorial();
                    fact.factor();
                    break;

                  case 6:
                    quotionremainder Myobj = new quotionremainder();
                    Myobj.compute();
                    break;

                   case 7:
                    Swaptwono swap = new Swaptwono();
                    swap.swapno();
                    break;

                    case 8:
                     evenodd num = new evenodd();
                     num.oddeven();
                    break;

                case 9:
                    wovel alpha = new wovel();
                    alpha.alphabat();
                    break;
                case 10:
                    Largestno num1 = new Largestno();
                    num1.largnumber();
                    break;
                default:
                    Console.WriteLine("plese  choose the correct option number");
                    break;
              }
         }
        
     }
        
            
    
}
