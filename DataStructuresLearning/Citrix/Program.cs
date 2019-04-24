using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input string count should be odd
            //Split into 2 array based on middle character and revere 1st arry alone
            string input = "3efdhka";

            //get the no of characters in the string
            int count = input.Length;

            //divide and conquer -get the mid index (7/2=3)
            int middleCharacter = count / 2;

            //get the mid index chracter to split the string
            char getMiddletCharacter = input[middleCharacter];

            //split string
            string[] splittedArray = input.Split(getMiddletCharacter);
            string leftPart = splittedArray[0];//3ef
            string rightPart = splittedArray[1];//hka

            //convert string to char array
            char[] leftCharArray = leftPart.ToCharArray();
            Array.Reverse(leftCharArray);//[3][e][f]---->[f][e][3]
            char[] rightCharArray = rightPart.ToCharArray();//[h][k][a]

            string temp = string.Empty;
            //******iterator=0*************leftCharArray.Length=3***************************
            //loop for 0+(0+1)+(1+1)=3 times
            for (int iterator = 0; iterator < leftCharArray.Length; iterator++)
            {
                temp = temp + leftCharArray[iterator].ToString() + rightCharArray[iterator].ToString();
            }
            Console.WriteLine(getMiddletCharacter.ToString() + temp);//3efdhka----->"d f h e k 3 a"
            Console.ReadLine();
        }
    }
}
