using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("How many time you want to greet: ");
            int greet = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < greet; i++)
            {
                Console.WriteLine("Good Morning!");
            }
            int g = greet;

            Console.WriteLine("--------while loop-----------");

            while (greet-- > 0)
            {
                Console.WriteLine("Hello world!");
            }

            
            do
            {
                Console.WriteLine("Welcome");
            } while (g-- > 0);


            Console.WriteLine("--------Conditional or ternoary operators----------");

            //condition ? true : false

            string result = greet >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
