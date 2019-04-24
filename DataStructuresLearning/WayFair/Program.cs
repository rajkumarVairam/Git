using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayFair
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "+6b25 +50 -2b25 +10b20 -50";
            
            string[] sarray = s.Split(' ');

            char[] c = s.ToCharArray();
            Array.Reverse(c);

            string test = "-2b25";
            bool yesOrNo = test.Contains('b');
            string[] sarray1 = test.Split('b');

            int i1 = Convert.ToInt32(sarray1[0]);
            for (int iterator=0;iterator< sarray.Length; iterator++)
            {

            }
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}
