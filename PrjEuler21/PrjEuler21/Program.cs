using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler21
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is brute force, look into Thabit ibn Qurra theorem for a faster way
            int[] divisorSumArray = new int[10001];
            bool[] isAmicable = new bool[10000];
            //find the sum of divisors for all numbers under 10000
            for(int i = 1; i <= 10000; i++)
            {
                int sumOfDivisors = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sumOfDivisors += j;
                }
                divisorSumArray[i] = sumOfDivisors;
            }
            int sumOfAmicableNumbers = 0;
            //find all the amicable numbers
            for (int i = 1; i < 10000; i++)
            {
                for (int j = 1; j < 10000; j++)
                    if (divisorSumArray[i] == j && divisorSumArray[j] == i && i != j)
                    {
                        isAmicable[i] = true;
                        break;
                    }
            }
            //add all the amicable numbers
            for (int i = 1; i < 10000; i++)
                if (isAmicable[i] == true)
                    sumOfAmicableNumbers += i;
            Console.WriteLine("Sum of amicable numbers: " + sumOfAmicableNumbers);
        }
    }
}
