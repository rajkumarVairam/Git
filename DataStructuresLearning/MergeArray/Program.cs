using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] xarray = new int[10];
            xarray[0] = 1;
            xarray[1] = 2;
            xarray[2] = 3;

            int lastIndex = 2;
            int[] yarray = new int[] { 4, 5 };

            
            int yarrLen = yarray.Length;

            int xarrLen = 0;

            for (int i=0;i<yarrLen;i++)
            {
                lastIndex = lastIndex +1;
                xarray[lastIndex] = yarray[i];
            }

            Console.WriteLine(xarray.Length);

            Console.WriteLine("Hello World!");

            int[] y = new int[] { 0,7,2,8,4,5,8,8};
            MinMaxSwap2(y);

            Console.WriteLine(ArrayContainsDuplicate(y));

            Console.WriteLine(ArrayContainsDuplicateArrayValue(y));

            Console.ReadKey();
        }

        //Cleaner implementation
        public static void MinMaxSwap2(int[] x)
        {
            int min = 0;
            int max = 0;

            int tempminIndex = 0;
            int tempmaxIndex = 0;

            for (int i=0;i<x.Length;i++)
            {
                if(min > x[i])
                {
                    min = x[i];
                    tempminIndex = i;
                }
                if(max < x[i])
                {
                    max = x[i];
                    tempmaxIndex = i;
                }
            }

            int temp = x[tempminIndex];
            
            x[tempminIndex] = x[tempmaxIndex];

            x[tempmaxIndex] = temp;

            Console.WriteLine("min value: "+min);
            Console.WriteLine("max value: " + max);

            Console.WriteLine("min value: " + x[tempminIndex]);
            Console.WriteLine("max value: " + x[tempmaxIndex]);

        }

        public static bool ArrayContainsDuplicate(int[] x)
        {
            Dictionary<int, int> tempD = new Dictionary<int, int>();
            for(int i=0;i<x.Length;i++)
            {
                if(tempD.ContainsKey(x[i]))
                {
                    return true;
                }
                tempD.Add(x[i], 1);
            }
            return false;
        }

        public static bool ArrayContainsDuplicateArrayValue(int[] x)
        {
            int[] temp = new int[20];

            ArrayList al = new ArrayList();

            for (int i = 0; i < x.Length; i++)
            {
                if (temp.Contains(x[i]))
                {
                    return true;
                }
                temp[i] = x[i];
            }
            return false;
        }
    }
}
