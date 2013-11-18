using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PrjEuler22
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + @"\names.txt");
            //split the input to an array of strings for each name, as there are no line breaks in the text file
            string[] nameStrings = reader.ReadLine().Split(',');
            List<string> nameList = new List<string>();
            //put the names in a list
            foreach (string n in nameStrings)
            {
                //substring starting at 1 and 2 less than the length to account for parentheses and a space
                nameList.Add(n.Substring(1, n.Length - 2));
            }
            nameList.Sort();
            int runningSum = 0;
            //add up all the scores multiplied by thier position
            for (int i = 0; i < nameList.Count; i++)
            {
                runningSum += (i + 1) * getScore(nameList[i]);
            }
            Console.WriteLine(runningSum);
        }

        public static int getScore(string input)
        {
            char[] arrayOfChars = input.ToCharArray();
            int scoreTotal = 0;
            foreach (char n in arrayOfChars)
                //add to the total using ascii values
                scoreTotal += (Convert.ToInt32(n) - 64);
            return scoreTotal;
        }


    }
}
