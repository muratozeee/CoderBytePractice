using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByteExamples
{
    public class FirstReverse
    {
        //
        //Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order.
        //For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH.

        public string ReverseWriting(string str)
        {
            string reverse = String.Empty;

            for(int i = str.Length - 1; i >= 0; i--)
            {

                reverse += str[i];

            }

            return reverse;

            

        }
    }
}
