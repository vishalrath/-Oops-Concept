using Oops_Program.ClassObjectce;
using System;

namespace Oops_Program.ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arithmatic program 

            /* calculator Myobj = new calculator();  //Creating Oject and call by calculator class
             Myobj.num1 = 20;                       //object initialize the value by calculator class
             Myobj.num2 = 20;

             Myobj.Add();                          //calling from Add method in calculator class
             Myobj.sub();*/

            //*********************************************************************************************************

            // Car program calling class and obj

            //Car.numb = 10;           not  working 
            //Car.numb = 10;

            /* Car swift = new Car();           //Creating Oject
             {
                 swift.model = "Swift123";       //its take car atribut ex. model, color, number
                 swift.color = "Black";
                 swift.numb = 123;
             }

             Car toyato = new Car();
             {
                 toyato.model = "Toyato2021";     //its take car atribut ex. model, color, number
                 toyato.color = "red";
                 toyato.numb = 221;
             }
             Car Maruti = new Car();
             {
                 Maruti.model = "Maruti1998";      //its take car atribut ex. model, color, number
                 Maruti.color = "blue";
                 Maruti.numb = 221;
             }
             swift.CarDetails();        // calling cardetails method in car class
             toyato.CarDetails();       // calling cardetails method in car class
             Maruti.CarDetails();       // calling cardetails method in car class */

            //******************************************************************************************************

            // Inheritance program

            // Single inheritance//

            /* Maruti MyCar = new Maruti();
             {
                 MyCar.model = "Maruti1998";
                 MyCar.color = "white";
                 MyCar.numb = 122112;
                 MyCar.mileage = 22.5F;
                 MyCar.CarDetails();
                 MyCar.Printmileage();
                 Console.ReadLine();
             }*/

            // multi level inheritance

            /* Maruti MyCar = new Maruti();       // creating object by void method in maruti class
              {
                  MyCar.model = "Maruti1998";          //bject insert value in data type veriable in Car class
                  MyCar.color = "white";
                  MyCar.numb = 122112;             //bject insert value in data type veriable in Maruti class
                  MyCar.mileage = 22;
                  MyCar.speed = 100;               // object insert value in data type veriable in Ferrari class
                  MyCar.price = 200000;
                  MyCar.CarDetails();              // mycar object call by CarDetails method in Merrari class
                  MyCar.Printmileage();           // mycar object call by Printmileage method in Merrari class
                  MyCar.PrintSpeedPrice();      // mycar object call by PrintSpeedPrice method in ferrari class
                  Console.ReadLine();
              }*/


            //   Hierarchical Inheritance

            /*Toyato Details = new Toyato();      // creating object by void method in toyata class   
                                                 // this  toyoto class is in herit in Car class
                 {
                Details.model = "Maruti1998";          //bject insert value in data type veriable in Car class
                Details.color = "white";
                Details.numb = 122112;             //bject insert value in data type veriable in Car class
                                               
                Details.CarDetails();              //  object call by CarDetails method in Car class
                //MyCar.Printmileage();           // mycar object call by Printmileage method in Merrari class
                    

                Details.Drive = "Smooth";          // object insert data in toyoto class in data type
                Details.Star = 5;
                Details.PassingYear = 2021;
                Details.Driving();                  // obj calling by method in toyato class
             }
                Ferrari Detail = new Ferrari();     // // creating object by void method in Ferari class class 
                                                    //// this  ferrari class is in herit in Car class
              {
                Detail.speed = 100;               // object insert value in data type veriable in Ferrari class
                 Detail.price = 200000;
                Detail.PrintSpeedPrice();              //obj calling by method in Ferrari class
                  Console.ReadLine();
            }*/

            // Encapsulation

            /* Account Mybalance = new Account();     //creating obj from Account class
             // Mybalance.SetBalance(-10);
             // Mybalance.GetBalance();         // using  Geter and Seter Method
             Mybalance.Balance = -1000;         //object call by properties
             Console.WriteLine("your account balance is:" + Mybalance.Balance);
            Console.ReadLine();*/

            // Abstraction 

            /*Student Stud = new Student();
            Stud.FirstName = "Vishal";
            Stud.LastName = "Rathod";
            Stud.age = 25 ;
            Stud.PhoneNumber = "7038762577";
            Stud.RollNo = 101;
            Stud.Fees = 10000;
            Stud.PrintDetails();
            Console.WriteLine("-------------------");


            Teacher teach = new Teacher();
            teach.FirstName = "vishal";
            teach.LastName = "Rathod";
            teach.age = 30;
            teach.PhoneNumber = "703872577";
            teach.Qualification = "Master in Computer Science";
            teach.Salary = 40000;
            teach.PrintDetails();*/

            //Polymorphism:
            //Two type of pollymorphism 1)compile time pollymorphism 2)Run time pollymorphism
            //
            //compile time pollymorphism achive using Method Overloding
            //Run time pollymorphism achive using  Method Overriding

            Overloding obj = new Overloding();
               obj.Sum(10,20);


            /*Overriding Tommy = new Overriding();
            Tommy.Eat();*/
            Console.ReadLine();




        }
    }

    }

