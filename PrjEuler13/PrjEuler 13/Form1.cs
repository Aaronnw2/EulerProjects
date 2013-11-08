using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string textInput = txtInput.Text;
            int[][] input = new int[100][];
            //input in all 100 digits
            for (int i = 0; i < 100; i++)
            {
                input[i] = new int[50];
                for (int j = 0; j < 50; j++)
                {
                    string singleInput = textInput.Substring(i * 50 + 2 * i+ j, 1);
                    if(singleInput != "\n" || singleInput != "\r")
                        input[i][j] = Convert.ToInt32(singleInput);
                }
            }
            int runningTotal = 0, carryAmount = 0, lastDigit = 0;
            int[] answer = new int[51];
            //loop to add the digits of the numbers
            for (int i = 0; i < 50; i++)
            {
                runningTotal = carryAmount;
                carryAmount = 0;
                //loop to add all 100 of the ith digits together
                for (int j = 0; j < 100; j++)
                {
                    runningTotal += input[j][49 - i];
                }
                //get the last digit of the sum for the answer
                lastDigit = runningTotal % 10;
                //find the carry amount left over after putting the answer for this digit
                carryAmount = (runningTotal - lastDigit) / 10;
                answer[51 - i - 1] = lastDigit;
            }
            //add the last carry amount to the begining of the number
            answer[0] = carryAmount;
            //put the answer in string form
            string output = "";
            for (int i = 0; i < 51; i++)
            {
                output = output + answer[i].ToString();
            }
            lbAnswer.Text = output;

        }
    }
}
