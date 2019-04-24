using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to find Factorial:");
            int num = int.Parse(Console.ReadLine());
            int fact=1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial: "+ fact);
            Console.WriteLine("Hello World!");

            PrintFibonacci();
            Console.ReadKey();
        }

        public static void PrintFibonacci()
        {
            Console.WriteLine("Enter length of Fibbonacci Series:");
            int lenFibSeries = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int j = 1;


            //5 length fibonacci seris 0 1 1 2 3

            int[] fibArr = new int[lenFibSeries];
            fibArr[0] = i;
            fibArr[1] = j;

            for(int jk=2;jk<lenFibSeries;jk++)
            {
                fibArr[jk] = fibArr[jk - 1] + fibArr[jk - 2];

            }
            int jj = 0;
            while (jj<fibArr.Length)
            {
                Console.WriteLine(fibArr[jj]);
                jj++;
            }

            Console.WriteLine(fibArr.Length);

        }
    }
}
