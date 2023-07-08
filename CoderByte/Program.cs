using CoderByteExamples;

namespace CoderByte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstFactorial firstFactorial = new FirstFactorial();
            FirstReverse firstReverse = new FirstReverse();
            LongestWord longestWord = new LongestWord();
            QuestionMark questionMark = new QuestionMark();


            string sentences = "Hello World ..MuratOz,?!&";

            //Factorial Example...

            int number1 = 8;
            //string str = "Hello World";

            string str = "lhjhjs5??dasd?5";
            Console.WriteLine(questionMark.QuestionMarks(str)); 

            //Console.WriteLine($"{number1}! = " + firstFactorial.Factorial(number1));

            //  Console.WriteLine("Before Reverse = " + str + "   After Reverse = " + firstReverse.ReverseWriting(str));


            // Console.WriteLine($"Longest Word = {longestWord.Longest(sentences)}");

     




















        }
    }
}