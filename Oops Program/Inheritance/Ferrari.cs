using Oops_Program.ClassObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                              // MULTILEVEL INHERITANCE
namespace Oops_Program.ClassObjectce
{
   
    class Ferrari:Car                                //Ferrari class (child class)is inherit to Car class (parent class)

            { 
              public int speed;                                         //declair data type and veriable
                public int price;

                   public void PrintSpeedPrice()                                // viod method calling by main class
                   {
                      // Console.WriteLine("speed is: "+ speed);                      // print to speed
                      //Console.WriteLine("price is: " + price);                       // print to speed
            Console.WriteLine("speed:{0} price:{1}", speed, price);            // data printing to one line 
        }
    }

    /*class Maruti : Ferrari        // maruti class (child class) is inherit by Ferrari class(parent class)

    {

        public float mileage;    // floting data type

        public void Printmileage()    // void method calling 
        {

            Console.WriteLine("mialeage is:" + mileage);

        }


    }
     
    class Program
    {
        public static void Main(string[] args)
        {

            Maruti MyCar = new Maruti();       // creating object by void method in maruti class
            {
                MyCar.model = "Maruti1998";          //bject insert value in data type veriable in Car class
                MyCar.color = "white";
                MyCar.numb = 122112;             //bject insert value in data type veriable in Maruti class
                MyCar.mileage = 22.5F;
                MyCar.speed = 100;               // object insert value in data type veriable in Ferrari class
                MyCar.price = 200000;
                MyCar.CarDetails();              // mycar object call by CarDetails method in Car class
                MyCar.Printmileage();           // mycar object call by Printmileage method in toyato class
                MyCar.PrintSpeedPrice();      // mycar object call by PrintSpeedPrice method in ferrari class
                Console.ReadLine();
            }
        }
    }*/
       
}
