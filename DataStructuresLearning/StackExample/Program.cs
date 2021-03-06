﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call this in Program.cs to test
            Console.WriteLine(Program.GetFizzBuzz());
            Console.ReadLine();
        }

        public static string GetFizzBuzz()
        {
            string fbString = "";
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    fbString += "FizzBuzz" + Environment.NewLine;
                else if (i % 3 == 0)
                    fbString += "Fizz" + Environment.NewLine;
                else if (i % 5 == 0)
                    fbString += "Buzz" + Environment.NewLine;
                else
                    fbString += i.ToString() + Environment.NewLine;
            }
            return fbString;
        }
    }
}
