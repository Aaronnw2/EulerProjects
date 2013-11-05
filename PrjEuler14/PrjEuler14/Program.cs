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
            alreadyVisitedNumber[] visitedNumbers = new alreadyVisitedNumber[1000000];
            for (int i = 0; i < 1000000; i++)
            {
                visitedNumbers[i] = new alreadyVisitedNumber();
            }
            for (int i = 2; i < 1000000; i++)
            {
                if(visitedNumbers[i].visited != true)
                {
                    //number hasn't been checked before
                    long testNumber = i;
                    int numberOfIterations = 0;
                    //main collatz algorithm
                    while(testNumber != 1)
                    {
                        if (testNumber % 2 == 0)
                            testNumber = testNumber / 2;
                        else
                            testNumber = (testNumber * 3) + 1;
                        //check if it's already cached
                        if(testNumber < 1000000)
                            if (visitedNumbers[testNumber].visited == true)
                            {
                                visitedNumbers[i].visited = true;
                                visitedNumbers[i].iterations = (numberOfIterations + visitedNumbers[testNumber].iterations);
                                break;
                            }
                        numberOfIterations++;

                    }
                    //if it hasn't been cached, do so now
                    if (visitedNumbers[i].visited != true)
                    {
                        visitedNumbers[i].visited = true;
                        visitedNumbers[i].iterations = numberOfIterations;
                    }
                }
                //check if it's the largest chain
                if (visitedNumbers[i].iterations > mostIterations)
                {
                    mostIterations = visitedNumbers[i].iterations;
                    valueWithMostIterations = i;
                }
            }
            Console.WriteLine("Number with most iterations: {0}, Number of iterations: {1}", valueWithMostIterations, mostIterations);
        }

        public class alreadyVisitedNumber
        {
            public bool visited;
            public int iterations;
            public alreadyVisitedNumber()
            {
                visited = false;
                iterations = 0;
            }
        }
    }
}
