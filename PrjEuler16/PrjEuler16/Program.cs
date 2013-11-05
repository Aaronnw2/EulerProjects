using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace PrjEuler16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the number of powers to raise 2, then find the sum of the digits");
            int power = Convert.ToInt32(Console.ReadLine());
            BigInteger total = 1;
            //find the answer of 2^n
            for (int i = 0; i < power; i++)
            {
                total = total * 2;
            }
            string digitString = total.ToString();
            int sumOfDigits = 0;
            //add all the digits up;
            for (int i = 0; i < digitString.Length; i++)
            {
                sumOfDigits += Convert.ToInt32(digitString.Substring(i,1));
            }
            Console.WriteLine("The sum of the digits of 2^{0} is {1}", power, sumOfDigits);
        }
    }
}
