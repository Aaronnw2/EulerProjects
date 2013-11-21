using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PrjEuler23
{
    class Program
    {
        static void Main(string[] args)
        {
            //abundant => sum of its divisors is greater than the number itself
            //compile a list of abundant numbers, perhaps with an upper bound of 28123 - 12
            List<int> abundantNumbers = new List<int>();
            Stopwatch timer = Stopwatch.StartNew();
            //find abundant numbers. some better bounds would help speed this up
            for (int i = 12; i < 28111; i++)
            {
                int sumOfFactors = 0;
                foreach(int n in findFactors(i))
                    sumOfFactors += n;
                if (sumOfFactors > i)
                    abundantNumbers.Add(i);
            }
            bool[] areSums = new bool[28123];
            //cross off all positive integers that are the sum of two abundant numbers
            foreach (int n in abundantNumbers)
                foreach (int m in abundantNumbers)
                    if(m + n < 28123)
                        areSums[n + m] = true;
            int runningSum = 0;
            //add all the numbers that aren't the sum of two abundant numbers together
            for(int i = 0; i < 28123; i++)
                if(areSums[i] == false)
                    runningSum += i;
            timer.Stop();
            Console.WriteLine(runningSum + "\nSolution took {0} ms", timer.ElapsedMilliseconds);
        }

        public static int[] findFactors(int inputNumber)
        {
            List<int> factors = new List<int>();
            factors.Add(1);
            //only need to check up to sqrt(input), as we also add two factors at the same time
            for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
                if (inputNumber % i == 0)
                {
                    factors.Add(i);
                    if(i * i != inputNumber) //check that it's not a perfect square
                        factors.Add(inputNumber / i);
                }
            return factors.ToArray();
        }
    }
}
