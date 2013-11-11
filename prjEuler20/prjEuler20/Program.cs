using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace prjEuler20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger fact = 1, sumOfDigits = 0;
            //find the factorial
            for(int i = 100; i > 1; i--)
            {
                fact *= i;
                Console.WriteLine(i);
            }
            //break it into digits
            string answerString = fact.ToString();
            int[] digitArray = new int[answerString.Length];
            for(int i = 0; i < answerString.Length; i++)
            {
                digitArray[i] = Convert.ToInt32(answerString.Substring(i,1));
                //add digits together
                sumOfDigits += digitArray[i];
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
