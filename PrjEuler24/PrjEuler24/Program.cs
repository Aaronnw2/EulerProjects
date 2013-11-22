using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler24
{
    class Program
    {
        static void Main(string[] args)
        {
            //this problem is basically asking us about the group S_10 with its permutations ordered numerically
            //there are 10! permutations in S10, or 3628800 permutations
            //when aranged in numerical order there will be 362880 permutations that start with 9, and another 362880 that start with 8, and so on
            //from this information we can tell the number will start with either a 2 or 3
            //infact, continuing this way using the order of S_n we could find the answer without much help from the computer
            //that will take us to the 725760th lexicographic permutation
            //then we repaetedly subtract 8! to get the second digit of 7 at 1008000
            //maybe use a while loop, find each digit in turn, using how many permutations S_n would use for that specific digit
            int[] digits = new int[10];
            digits[9] = 2;
            digits[8] = 7;
            int permutationNumber = 1008000;
        }
    }
}
