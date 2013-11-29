using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace PrjEuler25
{
    class Program
    {

/*
The Fibonacci sequence is defined by the recurrence relation:

    Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.

Hence the first 12 terms will be:

    F1 = 1
    F2 = 1
    F3 = 2
    F4 = 3
    F5 = 5
    F6 = 8
    F7 = 13
    F8 = 21
    F9 = 34
    F10 = 55
    F11 = 89
    F12 = 144

The 12th term, F12, is the first term to contain three digits.

What is the first term in the Fibonacci sequence to contain 1000 digits?
*/
        
        static void Main(string[] args)
        {
            BigInteger currentFibNumber = 1, previousFibNumber = 1;
            int termCounter = 2;
            //while the number of digits are less than 1000
            while (currentFibNumber.ToString().Length < 1000)
            {
                //find the next Fib number, and increment the counter
                BigInteger temp = currentFibNumber;
                currentFibNumber = currentFibNumber + previousFibNumber;
                previousFibNumber = temp;
                termCounter++;
            }
            Console.WriteLine(termCounter);
            //even faster would be using the closed form of fibb numbers of f_n = (phi)^n/sqrt(5), but I don't like that very much, it's too messy
            //we could also use while(biginteger.Divide(currentFibNumber, checkNumber) < 1)
            //where checkNumber = 10^999, but I thought this was a little bit more effiecient
        }
    }
}
