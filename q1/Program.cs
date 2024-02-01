using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        
        static void Main()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the number: ");
                int num = int.Parse(Console.ReadLine());
                if(num % 2 == 0)
                {
                    Console.WriteLine("This number is a even number");
                }
                else
                {
                    Console.WriteLine("This number is a odd number");
                }

            }
            Console.ReadLine();

        }

    }
}
