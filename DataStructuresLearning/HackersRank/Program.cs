using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HackersRank
{
    class Program
    {
        static void Main(string[] args)
        {

            //string braces = "{[}()]}}}";
            //char[] openparenthesis = new char[3] {'{','[','(' };
            //char[] closeparentheses = new char[3] { '}', ']', ')' };

            //ArrayList OpencurelybracArray = new ArrayList();
            //ArrayList OpencurelySqaureArray = new ArrayList();
            //ArrayList OpencurelybrackArray = new ArrayList();

            //ArrayList closecurelybracArray = new ArrayList();
            //ArrayList closecurelySqaureArray = new ArrayList();
            //ArrayList closecurelybrackArray = new ArrayList();

            //char[] getBracesCharacters = braces.ToCharArray();


            //for (int i=0;i<getBracesCharacters.Length;i++)
            //{
            //    Console.WriteLine(getBracesCharacters[i]+"\n");
            //    if(getBracesCharacters[i]=='{')
            //    {
            //        OpencurelybracArray.Add(getBracesCharacters[i]);
            //    }
            //    else if(getBracesCharacters[i] == '[')
            //    {
            //        OpencurelySqaureArray.Add(getBracesCharacters[i]);
            //    }
            //    else if (getBracesCharacters[i] == '(')
            //    {
            //        OpencurelybrackArray.Add(getBracesCharacters[i]);
            //    }
            //    else if (getBracesCharacters[i] == '}')
            //    {
            //        closecurelybracArray.Add(getBracesCharacters[i]);
            //    }
            //    else if (getBracesCharacters[i] == ']')
            //    {
            //        closecurelySqaureArray.Add(getBracesCharacters[i]);
            //    }
            //    else if (getBracesCharacters[i] == ')')
            //    {
            //        closecurelybrackArray.Add(getBracesCharacters[i]);
            //    }
            //}

            //int i1 = OpencurelybracArray.Count;
            //int i4 = closecurelybracArray.Count;

            //int i2 = OpencurelySqaureArray.Count;
            //int i5 = closecurelySqaureArray.Count;

            //int i3 = OpencurelybrackArray.Count;
            //int i6 = closecurelybrackArray.Count;


            //if(i1==i4 && i2==i5 && i3==i6 )
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}


            List<int> prices = new List<int>();

            prices.Add(5);
            prices.Add(1);
            prices.Add(3);
            prices.Add(4);
            prices.Add(6);
            prices.Add(2);

            int temp = 0;
            foreach(int i in prices)
            {
                temp = temp + i;
            }
            Console.WriteLine(temp);

            List<int> discountlist = new List<int>();
            List<int> nocountlist = new List<int>();
            for (int j=0;j< prices.Count;j++)
            {
                int currentprice = prices[j];
                List<int> templowlist = new List<int>();
                for(int k=j+1;k<prices.Count;k++)
                {
                    if(currentprice>= prices[k])
                    {
                        templowlist.Add(prices[k]);
                    }
                }
                if(templowlist.Count>0)
                {
                    discountlist.Add(currentprice - templowlist.Min());
                }
                else
                {
                    discountlist.Add(currentprice);
                    nocountlist.Add(currentprice);
                }
            }
            
            int temp1 = 0;
            foreach (int i1 in discountlist)
            {
                temp1 = temp1 + i1;
            }
            Console.WriteLine(temp1);

            Console.ReadLine();
        }
    }
}
