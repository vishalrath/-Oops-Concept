using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Harmonicnumber
    {
        public double nthHarmonic()
        {
            // H1 = 1
            float harmonic = 1;
            int N;
            Console.WriteLine("Enter a number: ");
            N = int.Parse(Console.ReadLine());

            // loop to apply the forumula
            // Hn = H1 + H2 + H3 ... +
            // Hn-1 + Hn-1 + 1/n
            for (int i = 2; i <= N; i++)
            {
                Console.Write("1/{0} + ", i);

                harmonic += (float)1 / i;
            }

            return harmonic;
        }
    }
}
