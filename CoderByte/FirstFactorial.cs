using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoderByte
{
    public class FirstFactorial
    {


        //Questions=Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it.
        //For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. For the test cases,
        //the range will be between 1 and 18 and the input will always be an integer.
        
        public int Factorial(int number)
        {

            //if(number>=1 && number <= 18)
            //{
            //    for (int i = number - 1; i >= 1; i--)
            //    {
            //        number *= i;

            //    }
            //    return number;
            //}
            //else
            //{
            //    return 1;
            //}


            //2.second answer..!
            for (int i = number - 1; i >= 1; i--) {
                  number *= i;

                 }

            return number == 1 && number>18 ? 1 : number;

        




        }





    }
}
