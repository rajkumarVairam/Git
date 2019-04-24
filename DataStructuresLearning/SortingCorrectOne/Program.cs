using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCorrectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("BubbleSort \n");
            BubbleSort();
            Console.Write("\n");

            Console.Write("SelectionSort \n");
            SelectionSort();
            Console.Write("\n");

            Console.Write("InsertionSort \n");
            InsertionSort();
            Console.Write("\n");

            Console.Write("MergeSort \n");
            MergeSort();
            Console.Write("\n");

            Console.Write("QuickSort \n");
            QuickSort();
            Console.Write("\n");

            Console.Write("HeapSort \n");
            HeapSort();
            Console.Write("\n");
            Console.ReadLine();
        }

        public static void BubbleSort()
        {
            int[] a = { 30, 20, 50, 40, 10 };
            int t;
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.Write("\n");
            for (int j = 0; j <= a.Length - 2; j++)
            {
                //Console.Write(j);
                //Console.Write("\n");
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    //Console.Write(i);
                    //Console.Write("\n");
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;       
                    }
                }
            }
            Console.Write("\n");
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.Write("\n");
        }

        public static void SelectionSort()
        {
            //int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            int[] array = new int[5] { 1, 7, 2, 4, 3 };
            Console.WriteLine("The Array Before Selection Sort is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int tmp, min_key;

            for (int j = 0; j < array.Length - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }

            Console.Write("\n");
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in array)
                Console.Write(aray + " ");
            Console.Write("\n");
        }

        public static void InsertionSort()
        {
            int[] data = new int[5] { 83, 12, 3, 34, 60 };
            int n = data.Length;
            Console.WriteLine("The Array Before Selection Sort is: ");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(data[k]);
            }

            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }

            Console.Write("\n");
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in data)
                Console.Write(aray + " ");
            Console.Write("\n");
        }

        /// <summary>
        /// MergeSort
        /// </summary>
        public static void MergeSort()
        {
            int[] data = new int[6] { 3,5,2,6,4,1 };
            int n = data.Length;
            Console.WriteLine("The Array Before Selection Sort is: ");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(data[k]);
            }
            MergeSort_Recursive(data, 0, n - 1);

            Console.Write("\n");
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in data)
                Console.Write(aray + " ");
            Console.Write("\n");
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }


        /// <summary>
        /// QuickSort
        /// </summary>
        public static void QuickSort()
        {
            int[] data = new int[9] { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int n = data.Length;
            Console.WriteLine("The Array Before Selection Sort is: ");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(data[k]);
            }
            QuickSort_Recursive(data, 0, n - 1);

            Console.Write("\n");
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in data)
                Console.Write(aray + " ");
            Console.Write("\n");
        }
        static public void QuickSort_Recursive(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }
        }
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        /// <summary>
        /// HeapSort
        /// </summary>
        public static void HeapSort()
        {
            int[] r = { 2, 5, 1, 10, 6, 9, 3, 7, 4, 8 };
            //int[] r = { 2, 5, 1, 10, 6 };
            Console.WriteLine("Elements Before sorting : ");
            print(r);
            hsort(r);
            Console.WriteLine("Elements After sorting : ");
            print(r);
        }
        
        public static void hsort(int[] r)
        {
            int i, t;
            for (i = 5; i >= 0; i--)
            {
                adjust(i, 9,r);
            }
            for (i = 8; i >= 0; i--)
            {
                t = r[i + 1];
                r[i + 1] = r[0];
                r[0] = t;
                adjust(0, i,r);
            }
        }
        private static void adjust(int i, int n, int[] r)
        {
            int t, j;
            try
            {
                t = r[i];
                j = 2 * i;
                while (j <= n)
                {
                    if (j < n && r[j] < r[j + 1])
                        j++;
                    if (t >= r[j])
                        break;
                    r[j / 2] = r[j];
                    j *= 2;
                }
                r[j / 2] = t;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Out of Bounds ", e);
            }
        }
        public static void print(int[] r)
        {
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine("{0}", r[i]);
            }

        }

    }
}
