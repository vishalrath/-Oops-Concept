using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{ 
    class Toyato:Car       //toyato class (child) is inherit by Car class(parent class)
    {
        public String Drive;
        public int Star;
        public int PassingYear;

        public void Driving()
        {
            //Console.WriteLine("Drive:{0} Star:{1} PassingYear:{2}", Drive, Star, PassingYear);
            Console.WriteLine("Driving is:" + Drive);
            Console.WriteLine("Star is:" + Star);
            Console.WriteLine("PassingYear is:" + PassingYear);
        }
    }
}
