using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();
            Console.Write("************************************************"+"\n");
            SelectionSort();
            Console.Write("************************************************" + "\n");
            Console.ReadLine();
        }

        /// <summary>
        /// BubbleSort
        /// </summary>
        public static void BubbleSort()
        {
            //int[] sortArray = new int[5] { 1, 7, 2, 4, 3 };
            //int[] sortArray = new int[3] {3,2,1 };
            int[] sortArray = new int[3] { 1, 2, 3 };
            int count = 0;
            //Bubble sort
            Console.Write("Bubble sort \n");
            for (int iterator = 0; iterator < sortArray.Length; iterator++)
            {
                count = count + 1;
                Console.Write("iterator " + iterator + "\n");
                for (int index = 0; index < sortArray.Length - 1; index++)
                {
                    count = count + 1;
                    Console.Write("index " + index + "\n");
                    if (sortArray[index] > sortArray[index + 1])
                    {
                        //Console.Write("sortArray[index] " + sortArray[index] + " sortArray[index+1] "+ sortArray[index + 1]+ "\n");
                        swap(ref sortArray[index], ref sortArray[index + 1]);
                    }
                }
            }
            PrintArray(sortArray);
            Console.Write("No of interations: " + count+"\n");
        }

        public static void SelectionSort()
        {
            //int[] sortArray = new int[3] { 3, 2, 1 };
            int[] sortArray = new int[5] { 1, 7, 2, 4, 3 };
            int indexOfMin = 0;
            int count = 0;
            for (int iterator=0;iterator<sortArray.Length-1;iterator++)
            {
                indexOfMin = iterator;
                count = count + 1;
                for (int index=iterator+1;index<sortArray.Length;index++)
                {
                    count = count + 1;
                    if (sortArray[index]<sortArray[indexOfMin])
                    {
                        indexOfMin = index;
                        Console.Write("indexOfMin in iteration " + iterator + " position: " + indexOfMin + "\n");
                        swap(ref sortArray[iterator], ref sortArray[indexOfMin]);
                    }
                }

            }
            PrintArray(sortArray);
            Console.Write("No of interations: " + count + "\n");
        }

        /// <summary>
        /// common swap function
        /// </summary>
        /// <param name="valOne"></param>
        /// <param name="valTwo"></param>
        public static void swap(ref int valOne,ref int valTwo)
        {
            valOne = valOne + valTwo;
            valTwo = valOne - valTwo;
            valOne = valOne - valTwo;
        }

        /// <summary>
        /// Print sorted Array
        /// </summary>
        /// <param name="arrayInput"></param>
        public static void PrintArray(int[] arrayInput)
        {
            List<int> lin = arrayInput.ToList();
            foreach (int i in lin)
            {
                Console.WriteLine(i);
            }
        }
    }
}
