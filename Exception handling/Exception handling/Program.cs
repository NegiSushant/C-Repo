using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.FormatException
            //System.OverflowException
            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }catch (OverflowException)
            {
                Console.WriteLine("Please only a number less then 2 billion!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter numbers!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();

        }
    }
}
