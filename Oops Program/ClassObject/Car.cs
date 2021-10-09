using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{
    //prototype or blueeprint of car object
    class Car
    {
          //instance veriable
        public string color;       //access modifier data type name of veriable
        public string model;

        public int numb;

        public void CarDetails()      //CarDetails()  is a void method 
        {
            Console.WriteLine("color:{0} model:{1} number:{2}", color, model, numb);  // printing to one line data
        }

    }

    //this maruti class is use to inhetance  

     /* class Maruti : Car                         // maruti class is child class  //maruti class in herit to car class

 {

     public float mileage;                        // floating data type 

     public void Printmileage()                    // void method callby main class
     {

         Console.WriteLine("mialeage is:" + mileage);

     }


 }

    class Program                            // main method class
    {
        static void Main(string[] args)        //void mein method class
        {
            Maruti MyCar = new Maruti();      //create object maruti class
            {
                MyCar.model = "Maruti1998";     //initializing  data calling class
                MyCar.color = "white";
                MyCar.numb = 122112;
                MyCar.mileage = 22.5F;
                MyCar.CarDetails();                 //cali by CarDetail method in car class
                MyCar.Printmileage();            //cali by printmileage method in maruti class

                Console.ReadLine();
            }
        }
    }*/
}
