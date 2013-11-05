using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace PrjEuler15
{
    class Program
    {
        static void Main(string[] args)
        {
            //all paths are of length 2n, we just need to pick which n segments are, for example, down. The rest will be to the right.
            //the answer to any grid of size n is: (2n choose n) or 2n!/(n!*(2n-n)!) or 2n!/(n!)^2
            BigInteger nFact = 1, twoNFact = 1;
            Console.WriteLine("Input n for paths of an NxN grid");
            int input = Convert.ToInt32(Console.ReadLine());
            //compute the values of n! and 2n!
            for (int i = 1; i <= 2 * input; i++)
            {
                if (i <= input)
                    nFact *= i;
                twoNFact *= i;
            }
            //using definition of the choose function to find the answer
            BigInteger answer = twoNFact / (nFact * nFact);
            Console.WriteLine("Paths for a {1}x{1} grid: {0}", answer, input);
        }
    }
}
