using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler14
{
    class Program
    {
        static void Main(string[] args)
        {
            //caching, make a bool array that is false for all values below a million that we hit along the way, as we know that the length will be shorter for those numbers than the one we started from, and therefore cant be the longest sequence
            int mostIterations = 0, valueWithMostIterations = 0;
            for (int i = 2; i < 1000000; i++)
            {
                int numberOfIterations = 0;
                long testNumber = i;
                while (testNumber != 1)
                {
                    if ((testNumber % 2) == 0)
                    {
                        //even
                        testNumber = testNumber / 2;
                    }
                    else
                    {
                        //odd
                        testNumber = (3 * testNumber) + 1;
                    }
                    numberOfIterations++;
                }
                //Console.WriteLine(i + ": " + numberOfIterations);
                //check if its the longest
                if(numberOfIterations > mostIterations)
                {
                    mostIterations = numberOfIterations;
                    valueWithMostIterations = i;
                }
            }
            Console.WriteLine("Number with most iterations: {0}, Number of iterations: {1}", valueWithMostIterations, mostIterations);
        }
    }
}
