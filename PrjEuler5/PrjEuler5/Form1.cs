using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt32(txtInput.Text);
            bool[] neededDivisors = new bool[inputNumber + 1];
            for (int i = 1; i <= inputNumber; i++)
                neededDivisors[i] = true;
            List<int> divisors = new List<int>();
            //remove numbers that divide another divisor
            for (int i = inputNumber; i > 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (neededDivisors[j] == true)
                        if (i % j == 0)
                            neededDivisors[j] = false;
                }
            }
            //this will give us a smaller list of divisors to multiply together to get an upper boud on the solution
            for (int i = 1; i < inputNumber + 1; i++)
                if (neededDivisors[i] == true)
                    divisors.Add(i);
            int upperLimit = 1;
            //set the upper limit to all divisors multiplied together
            foreach (int i in divisors)
                upperLimit = upperLimit * i;
            int tryNumber = divisors.Max();
            //find the smallest number between the highest divisor and the upper limit that is evenly divisable by all divisors
            bool solutionFound = false;
            do
            {
                //only need to check increments of the highest factor
                tryNumber = tryNumber + divisors.Max();
                //try each divisor to see if it works
                foreach (int i in divisors)
                {
                    //doesnt divide
                    if (tryNumber % i != 0)
                        break;
                    else
                        //check if all needed divisors have already worked
                        if (i == divisors.Max())
                            //solution has been found
                            solutionFound = true;
                }
                //if we have searched all the way to the upper limit, then that is the lowest answer
                if (tryNumber == upperLimit)
                    solutionFound = true;
            } while (solutionFound == false);
            lblAnswer.Text = tryNumber.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalculate.Focus();
        }
    }
}
