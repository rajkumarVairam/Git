using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 2, 1, 0, 0, 4,0,9,10,1 };

            int lastIndex = x.Length - 1;

            for(int i=0;i<= lastIndex; i++)
            {
                if(x[i]==0)
                {
                    int temp = x[lastIndex];
                    x[lastIndex] = x[i];
                    x[i] = temp;
                    lastIndex = lastIndex - 1;
                }
            }

            Console.WriteLine(x[lastIndex]);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
