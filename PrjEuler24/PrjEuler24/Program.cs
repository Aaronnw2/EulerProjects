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
            bool[] usedDigit = new bool[10];
            int[] digits = new int[10];
            int startNumber = 0, digitCounter = 0, digitToAdd = 0;
            while (startNumber < 1000000)
            {
                //add digitcounter! to the number of permutations
                startNumber = startNumber + (fact(9 - digitCounter));
                //check if the total permutations is over 1 million
                if (startNumber >= 1000000)
                {
                    //the next digit has been found
                    digits[digitCounter] = digitToAdd;
                    //mark it as used
                    usedDigit[digitToAdd] = true;
                    //rool back one factorial so we are back under 1 million
                    startNumber = startNumber - fact(9 - digitCounter);
                    //start looking for the next digit
                    digitCounter++;
                    digitToAdd = -1;
                    //if we found the last digit, exit
                    if (digitCounter == 10)
                        break;
                }
                //find the next unused number
                do
                {
                    //set the number to add as the next smallest    
                    digitToAdd++;
                } while (usedDigit[digitToAdd] == true);
            }
            //print out the number
            for(int i = 0; i < 10; i++)
                Console.Write(digits[i]);
            Console.Write("\n");
        }

        //takes an int input and outputs input!
        public static int fact(int input)
        {
            int answer = 1;
            for (int i = input; i > 1; i--)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
