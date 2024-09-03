using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: "+age);

            Console.WriteLine("-----------------Conditional statements-----------------------");

            //==, >, >=, <, <=, !=

            if(age >= 18)
            {
                Console.WriteLine("your age is "+age+", You are eligible to cast your vote");
            }
            else
            {
                Console.WriteLine("Your  age is "+age+", you are not eligible to cast your vote!");
            }

            Console.WriteLine("------Switch Statements------------");

            Console.WriteLine("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Monday");
                    break;

                case 2: Console.WriteLine("Tuesday");
                    break;

                case 3: Console.WriteLine("Wednessday");
                    break;

                case 4: Console.WriteLine("Thursday");
                    break;

                case 5: Console.WriteLine("Friday");
                    break;

                case 6: Console.WriteLine("Saturday");
                    break;

                case 7: Console.WriteLine("Sunday");
                    break;

                default: Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
