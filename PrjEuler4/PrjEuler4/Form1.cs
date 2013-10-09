using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numberOfDigits = Convert.ToInt32(txtNumberOfDigits.Text);
            int largestNumber = 10;
            for (int i = 1; i < numberOfDigits; i++)// get largestNumber to 10^(numberOfDigits) - 1
            {
                largestNumber = largestNumber * 10;
            }
            largestNumber = largestNumber - 1;
            List<int> foundPalindromes = new List<int>();
            //find the largest palindrome of largest number * n < largest number
            for (int j = largestNumber; j > 3; j--)//3 to exclude 1 digit palindromes
            {
                for (int i = largestNumber; i > 3; i--)//3 to exlude 1 digit palindromes
                {
                    string palindromString = (j * i).ToString(), firstHalf, secondHalf;
                    if (palindromString.Length % 2 == 0)
                    {
                        //even number of digits, split the number in two, and reverse the second half
                        firstHalf = palindromString.Substring(0, palindromString.Length / 2);
                        secondHalf = palindromString.Substring(palindromString.Length / 2);
                        secondHalf.Reverse();
                        char[] tempRevArray = secondHalf.ToCharArray();
                        Array.Reverse(tempRevArray);
                        secondHalf = new string(tempRevArray);
                    }
                    else
                    {
                        //odd number of digits, split the number in two, and reverse the second half
                        firstHalf = palindromString.Substring(0, palindromString.Length / 2);
                        secondHalf = palindromString.Substring(palindromString.Length / 2 - 1);
                        char[] tempRevArray = secondHalf.ToCharArray();
                        Array.Reverse(tempRevArray);
                        secondHalf = new string(tempRevArray);

                    }
                    //check if they're equal
                    if (secondHalf == firstHalf)
                    {
                        //largest palindrome found for this combination of i and largest number
                        foundPalindromes.Add(Convert.ToInt32(palindromString));
                        break; //the largest has been found for these two numbers i and j, there's no need to search further
                    }
                }
            }
            if (foundPalindromes.Count != 0)
                lblAnswer.Text = foundPalindromes.Max().ToString();//print the largest of the found palindromes
            else
                lblAnswer.Text = "None found!";
        }
    }
}
