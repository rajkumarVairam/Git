using System;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace CoderPad
{


    // To execute C#, please define "static void Main" on a class
    // named Solution.

    class Solution
    {
        static char tempCharacter;
        static int firstIndex = 0;
        static void Main(string[] args)
        {
            /*for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello, World");
            }*/
            Console.WriteLine("Enter a no:");
            int iget = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have entered: {0}", iget);

            string s1 = "Twitter";
            int tempIndex = 0;
            
            char[] c1 = s1.ToCharArray();
            Dictionary<char, int> ds = new Dictionary<char, int>();
            for(int i=0;i<c1.Length;i++)
            {
                char ctemp = char.ToLower(c1[i]);
                if (!ds.ContainsKey(ctemp))
                {
                    ds.Add(ctemp, i);
                }
                else
                {
                    tempIndex = i;
                    tempCharacter = c1[i];
                    i = c1.Length;
                }
            }
            int firstIndex = 0;
            for (int j=0;j<ds.Count;j++)
            {
                if (ds.ContainsKey(tempCharacter))
                {
                    firstIndex = j;
                    j = ds.Count;
                }
            }

            

            Dictionary<char, int> ds1 = new Dictionary<char, int>();
            ds1 = ds;

            int[] myInt = new int[5] { 83, 31, 4, 78, 2 };
            int temp = 0;


            for (int j = 0; j <= myInt.Length - 2; j++)
            {
                //Console.Write(j);
                //Console.Write("\n");
                for (int i = 0; i <= myInt.Length - 2; i++)
                {
                    //Console.Write(i);
                    //Console.Write("\n");
                    if (myInt[i] > myInt[i + 1])
                    {
                        temp = myInt[i + 1];
                        myInt[i + 1] = myInt[i];
                        myInt[i] = temp;
                    }
                }
            }

            for (int a = 0; a < myInt.Length; a++)
            {
                Console.WriteLine(myInt[a] + " ");
                Console.WriteLine("\n");
            }
            ArrayList al = new ArrayList();
            al.Add("hello");
            al.Add("world");
            al.Add("i am good to go");

            foreach (string s in al)
            {
                Console.WriteLine(s + " ");
                Console.WriteLine("\n");
            }
            Employee e = new Employee();
            string palindrome = "madam";
            char[] c = palindrome.ToCharArray();
            Console.ReadLine();
        }
    }

    class Node
    {
        int data;
        Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    class BinaryNode
    {
        int data;
        BinaryNode left;
        BinaryNode right;
        public BinaryNode()
        {

        }
    }

    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Hello");
        }

    }


}
