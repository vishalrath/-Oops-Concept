using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Program.ClassObject
{

    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Dog "implements" the IAnimal interface
    class Dog1 : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The Dog says: Bhow Bhow");
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
    }*/


   
}
