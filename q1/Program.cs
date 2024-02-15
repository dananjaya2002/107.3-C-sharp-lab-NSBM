using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Animal
    {
        public void Speak()
        {
            Console.Write("I am an Animal ");
        }
    }
    public class Dog : Animal
    {
        public void NumberofLegs()
        {
            Console.Write("I have four Legs ");
        }
    }
    internal class Program
    {
       public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Speak();
            dog.NumberofLegs();

            Console.ReadLine();
        }

        

    }
}
