using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGMandLCD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greatest Commom divisor
            //Least common multiple

            int num1 = 2;
            int num2 = 4;

            int gcd= GetGCD(num1,num2);
            int lcm = GetLCM(num1, num2);
            Console.WriteLine("Hello World!");

            Console.WriteLine(gcd);
            Console.WriteLine(lcm);
            Console.ReadKey();
        }

        static int GetGCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;

                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num1;
        }

        static int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }
    }
}
