using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

using System.Collections.Concurrent;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarry = new string[5];
            sarry[0] = "Rajkumar";
            sarry[1] = "Vairam";

            int[] iarry = new int[2];
            
            iarry[0] = 1000;
            iarry[1] = 1001;

            Console.WriteLine("Printing string array "+ sarry[0].ToString().ToUpper());
            Console.WriteLine("Printing string array " + sarry[1].ToString().ToUpper());

            Console.WriteLine("Printing int array " + iarry[0].ToString().ToUpper());
            Console.WriteLine("Printing int array " + iarry[1].ToString().ToUpper());

            ArrayList myarrayList = new ArrayList();
            myarrayList.Add("Printing int arraylist " + sarry[0]);
            myarrayList.Add("Printing int arraylist " + iarry[1]);

            Console.WriteLine(myarrayList[1]);

            //LinkedList<string, int> stringint = new LinkedList<string, int>();
            List<int> lint = new List<int>();
            lint.Add(1002);
            lint.Add(iarry[0]);

            string s = "madam";
            s.ToCharArray();

            Console.WriteLine("Printing int List "+lint[1].ToString());

            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(5);
            linkedlist.AddLast(7);

            Console.WriteLine("Printing LinkedList FirstNextValue " + linkedlist.First.Next.Value);
            Console.WriteLine("Printing LinkedList FirstValue " + linkedlist.Find(5).Value);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);

            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1, 1);
            d.Add(2, 1);
            d.Add(3, 1);
            d.Add(4, 1);
            int i = 0;
            int ivalue = i++;
            ivalue = i;
            Console.WriteLine("Dictionary Post increment ivalue " + ivalue);
            Console.WriteLine("Dictionary  Post increment value of I " + i);

            Console.WriteLine("Dictionary  Post increment value of dictionary " + d[i]++);

            int j = 0;
            int Jvalue = ++j;
            Jvalue = j;
            Console.WriteLine("Dictionary Pre increment Jvalue " + Jvalue);
            Console.WriteLine("Dictionary Pre increment value of J " + j);

            Console.WriteLine("Printing Dictionary using keyValue " + dict["one"]);

            Hashtable myTable = new Hashtable();
            myTable.Add("Rajkumar", 1);
            myTable.Add(5,"five");
            myTable.Add(7, "seven");

            Console.WriteLine("Printing Hashtable using keyValue " + myTable[7]);


            HashSet<int> mySet = new HashSet<int>();
            mySet.Add(3);
            mySet.Add(5);
            mySet.Add(3);
            mySet.Add(10);


            

            List<int> myListFromSet = mySet.ToList<int>();
            int myInt = myListFromSet[2];

            Console.WriteLine("Printing int using HashSet " + myInt);

            Stack stack = new Stack();
            stack.Push("one");
            stack.Push(2);
            stack.Push("three");
            stack.Push(4);
            stack.Push("five");
            Console.WriteLine("Stack value from peek: " + stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("Stack value from pop: " + stack.Pop());
            }

            Queue queue = new Queue();
            queue.Enqueue("one");
            queue.Enqueue(2);
            queue.Enqueue("three");
            queue.Enqueue(4);
            queue.Enqueue("five");

            Console.WriteLine("queue value from peek: " + queue.Peek());

            

            while (queue.Count > 0)
            {
                Console.WriteLine("Queue value from dequeue: " + queue.Dequeue());
            }


            Console.WriteLine("Hello World!");

            
            
            Console.ReadKey();
        }
    }
}
