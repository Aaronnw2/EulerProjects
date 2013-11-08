using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler18
{
    class Program
    {
        static void Main(string[] args)
        {
            //we can weight each entry of each row, then find paths with maximum weight
            //maybe use a binary tree
            string input = "75 95 64 17 47 82 18 35 87 10 20 04 82 47 65 19 01 23 75 03 34 88 02 77 73 07 63 67 99 65 04 28 06 16 70 92 41 41 26 56 83 40 80 70 33 41 48 72 33 47 32 37 16 94 29 53 71 44 65 25 43 91 52 97 51 14 70 11 33 28 77 73 17 78 39 68 17 57 91 71 52 38 17 14 91 43 58 50 27 29 48 63 66 04 68 89 53 67 30 73 16 69 87 40 31 04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            //load in values to 2-D array
            int count = 0;
            int[][] inputArray = new int[15][];
            for (int i = 0; i < 15; i++)
            {
                //create an array of lenght i for each consecutive row
                count = count + i;
                inputArray[i] = new int[i + 1];
                string currentLine = input.Substring(3 * count, 2 + i * 3);
                for(int j = 0; j <= i; j++)
                {
                    //fill in the rows
                    inputArray[i][j] = Convert.ToInt32(currentLine.Substring(j * 3, 2));
                }
            }
            triangleSumFinder(inputArray);
        }

        //true means straight is highest, false means the right triangle is higher
        static bool triangleSumFinder(int[][] inputTriangle)
        {
            if (inputTriangle.Length > 1)
            {

            }
            return true;
        }
    }
}
