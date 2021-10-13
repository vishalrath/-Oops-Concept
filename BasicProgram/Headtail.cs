using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Headtail
    {
       public  int Coin()
        {
            Random Rand = new Random();

            int heads = 0;
            int tails = 0;
            int result = 0;
            float percent = 0;
            int n;
     
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Haed ");
                    heads++;
                    percent =  (heads / n) * 100;
                    Console.WriteLine("Haed of percent:" + percent);
                }

                else

                {
                    Console.WriteLine("Tails ");
                    tails++;
                    percent = (tails / 10) * 100;
                    Console.WriteLine("Tails of percent:" + percent);
                }
            }

            Console.WriteLine("heads was flipped {0} times", heads);

            Console.WriteLine("tails was flipped {0} times", tails);

            return result;

        }

    }
}
