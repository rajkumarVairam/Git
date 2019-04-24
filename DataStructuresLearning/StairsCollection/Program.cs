using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int noSteps = CombosIterative(12);
            Console.ReadKey();
        }


        //Iterative solution with caching
        public static int CombosIterative(int numStairs)
        {
            if (numStairs > 36)
                throw new Exception("Int overflow");
            if (numStairs <= 0)
                return 0;
            if (numStairs == 1)
                return 1;
            if (numStairs == 2)
                return 2;
            if (numStairs == 3)
                return 4;
            int[] prev = { 1, 2, 4 };

            //We only start caching results if numStairs is more than 3
            int current = 3;
            while (current < numStairs)
            {
                int preTotal = prev[0] + prev[1] + prev[2];
                prev[0] = prev[1];
                prev[1] = prev[2];
                prev[2] = preTotal;
                current++;
            }
            return prev[2];
        }

    }
}
