using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoderByteExamples
{
    public class QuestionMark
    {



        public string QuestionMarks(string str)
        {

            int count = 0;
            //6???4
            bool foundPair = false;
            for(int i=0; i<str.Length; i++)//0
            {
                char c = str[i];//0
                if (Char.IsDigit(c))//6
                {
                    int num1 = c - '0';//6
                    for (int j = i + 1; j < str.Length; j++)//1234
                    {
                        char c2 = str[j];//???4

                        if (Char.IsDigit(c2))
                        {
                            int num2 = c2 - '0';//4
                            if (num1 + num2 == 10)//10
                            {
                                if (count != 3)
                                    return "false";
                                foundPair = true;
                                break;
                            }
                            else
                            {
                                count = 0;
                            }
                        }
                        else if (c2 == '?')
                        {
                            count++;//123
                        }
                    }
                    if (!foundPair)
                    {
                        return "false";
                    }

                }
            }
            return foundPair ? "true" : "false";
        }
    }

}
