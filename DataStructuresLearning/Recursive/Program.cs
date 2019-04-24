using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Call recursive method with two parameters.
            //
            int count = 0;
            int total = RecursiveFunc(8, ref count);
            //
            // Write the result from the method calls and also the call count.
            //
            Console.WriteLine(total);
            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static int RecursiveFunc(int value, ref int count)
        {
            count = count + 1;
            if(value>=10)
            {
                return value;
            }
            return RecursiveFunc(value + 1, ref count);
        }
    }
}
