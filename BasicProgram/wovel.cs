using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class wovel
    {
        public void alphabat()
        {
            char ch;
            Console.WriteLine("enter the alphabate :");
            ch = Convert.ToChar(Console.ReadLine());

            // Condition for vowel checking
           /* if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel.");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }*/
           switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;

                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;

                default:
                    Console.WriteLine("The alphabate is vowel");
                    break;




            }

        }
    }
}
