using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByteExamples
{
    public class LongestWord
    {
        public string Longest(string sentences)
        {

            string[] words = sentences.Split(new char[] {' ', '.' , ',' , '!' , '?' , '&' },
                StringSplitOptions.RemoveEmptyEntries);

            string longest = words.OrderByDescending(l => l.Length).First();

            return longest;



           
        }


    }




}
