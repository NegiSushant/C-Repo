using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //System.Console.WriteLine("Hello World!");

            int x = 10;
            int y = 20;
            int z = 30;

            int p = 40, q = 50, r = 60;


            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int age = 23;
            Console.WriteLine(age);


            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.00000F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);


            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            age = 30;
            Console.WriteLine(age);


            string name = "abcd0";
            string naam = " ";

            char latter = 'a';
            //char let1 = ''; //give error
            char let2 = '\0';

            Console.WriteLine("Your name is: "+ name);
            Console.WriteLine("char is "+latter);


            string textArea = "-23";
            int ages = Convert.ToInt32(textArea);
            Console.WriteLine(ages);

            string textBigNumber = "-900000000";
            long bi = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bi);

            string negativeText = "-55.2";
            double negative1 = Convert.ToDouble(negativeText);
            Console.WriteLine(negative1);

            string textPrecision = "5.00001";
            float pre = Convert.ToSingle(textPrecision);
            Console.WriteLine(pre);

            string textMoney = "14.99";
            decimal money1 = Convert.ToDecimal(textMoney);
            Console.WriteLine(money1);


            Console.WriteLine("-----------Boolean DataType---------------");

            bool value = true;

            bool isMale = true;

            Console.WriteLine(value);
            Console.WriteLine(isMale);


            Console.WriteLine("-----------------operators------------------");
            int age2 = 23;
            age2++;
            Console.WriteLine(age2);

            age2--;
            Console.WriteLine(age2);
            
            age2 /= 10;
            Console.WriteLine(age2);

            double age3 = 23;

            age3 /= 10;
            Console.WriteLine(age3);

            Console.WriteLine("-----------var keyword-------------");
            var something = 50;
            Console.WriteLine(something);
            //var x; //gives error
            var bigNum = 9000000L;
            Console.WriteLine(bigNum);


            var pres = 5.10002F;
            Console.WriteLine(pres);


            var moneys = 14.99M;
            Console.WriteLine(moneys);

            var lets = 'S';
            Console.WriteLine(lets);

            var names = "Something";
            Console.WriteLine(names);

            Console.WriteLine("----------Const keywords-----------");

            const int num = 29;
            //num = 20; //compile errors
            const double perVat = num / 100D;

            Console.WriteLine(perVat * num);
            int balance = 1000;
            Console.WriteLine(balance * (num /100D));
            Console.WriteLine(num);



            Console.ReadLine();
        }
    }
}
