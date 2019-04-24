using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmStrongNo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<int>> ln = new List<List<int>>();

            //List<int> a = new List<int>();



            //int[,] xyArray = new int[,] { { 1, -3 }, { 1, 2 }, { 3, 4 } } ;

            //int temp1 = 0;
            //int temp2 = 0;


            //// Get all bounds before looping.
            //int bound0 = xyArray.GetUpperBound(0);
            //int bound1 = xyArray.GetUpperBound(1);

            //int[] squarArray = new int[3];
            //// ... Loop over bounds.
            //for (int i = 0; i <= bound0; i++)
            //{
            //    temp1 = 0;
            //    temp2 = 0;
            //    for (int x = 0; x <= bound1; x++)
            //    {

            //        // Display the element at these indexes.
            //        Console.WriteLine(xyArray[i, x]);

            //        temp1 = (xyArray[i, x] * xyArray[i, x]);
            //        temp2 = temp2 + temp1;
            //        Console.WriteLine(temp2);
            //    }
            //    squarArray[i] = temp2;

            //    Console.WriteLine();
            //}

            //Array.Sort(squarArray);
            //for (int i = 0; i < squarArray.Length; i++)
            //{
            //    Console.WriteLine("printing sqaure root");
            //    Console.WriteLine(Math.Sqrt(squarArray[i]));
            //    Console.WriteLine(squarArray[i]);
            //    Console.WriteLine();
            //}
            Console.WriteLine(Math.Sqrt(0.477));
            Console.WriteLine(Math.Log10(5));
            Console.WriteLine("Enter a number to find divisble to by 2");
            int ij = Convert.ToInt32(Console.ReadLine());

            if(ij%2==0)
            {
                Console.WriteLine("Number divisble by 2");
            }
            else
            {
                Console.WriteLine("Number is not divisble by 2");
            }


            Console.WriteLine("Enter a string:");
            string getString = Console.ReadLine();
            char[] c = getString.ToCharArray();
            string temp = "";

            int length = c.Length - 1;

            for (int i = length; i >= 0; i--)
            {

                temp = temp + c[i];
            }

            if(temp.Equals(getString))
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }
            Console.ReadLine();

            Console.WriteLine("Enter a string to find out the substring:");
            string subString = Console.ReadLine();

            //Console.WriteLine(subString.Substring(1,5));

            for(int i=1;i<=subString.Length;i++)
            {
                Console.WriteLine(subString.Substring(i - 1, i));
            }

            Console.ReadLine();

        }


        

     
        
    }
    
}
