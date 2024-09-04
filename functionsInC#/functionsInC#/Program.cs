using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Something";
            Console.WriteLine("Welcome!");
            Welcome();
            Console.WriteLine(ReturnName()); ;
            Console.ReadLine();
        }
        static void Welcome()
        {
            Console.WriteLine("Hello world!");
        }

        static string ReturnName()
        {

            return "I'm from string datatype";
        }
        static int ReturnAge()
        {

            return 0;
        }
    }
}
