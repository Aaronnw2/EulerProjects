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
            int[] answer = new int[200];
            for (int i = 0; i < 50; i++)
            {
                runningTotal = carryAmount;
                carryAmount = 0;
                for (int j = 0; j < 100; j++)
                {
                    runningTotal += input[100 - j - 1][50 - i - 1];
                }
                lastDigit = runningTotal % 10;
                carryAmount = runningTotal - lastDigit / 10;
                answer[200 - i - 1] = lastDigit;
            }
            answer[0] = carryAmount;
        }
    }
}
