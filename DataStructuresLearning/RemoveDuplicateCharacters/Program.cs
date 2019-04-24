using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string word = "Google yahoo";
            string table = "";
            string value = "";

            foreach(char k in word)
            {
                if(table.IndexOf(k)==-1)
                {
                    table += k;
                    value += k;
                }
            }
            Console.WriteLine(table);
            Console.WriteLine(value);

            int a = 5;
            int b = 8;
            int c = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);

            c = b;
            b = a;
            a = c;

            Console.WriteLine(a);
            Console.WriteLine(b);



            for(int i=0;i<=5;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Reverse a string");
            string reverseMe = "RAJKUMAR";

            Console.WriteLine("Enter a word to check polindrome:");
            string getMe= Console.ReadLine();

            string temp = "";
            for(int i= getMe.Length -1;i>=0;i--)
            {
                temp = temp + getMe[i];
                
            }
            Console.WriteLine(temp);

            bool me = getMe.Equals(temp);
            Console.WriteLine("Your enter polidrome sting is:" + me);

            char[] chararragy = temp.ToCharArray();
            foreach(char ab in chararragy)
            {
                Console.WriteLine(ab);
            }

            int[] majority = new int[] { 1, 2, 3, 4, 5, 2, 2, 2 };

            int getManjority = GetMajorityElement(majority);
            Array.Sort(majority);

            int[] newMajority = majority;

            
            Console.WriteLine(getManjority);
            Console.ReadKey();
        }

        //Find majority element in an unsorted array
        //Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority element because it accounts for more than 50% of the array
        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            throw new Exception("No majority element in array");
        }
    }
}
