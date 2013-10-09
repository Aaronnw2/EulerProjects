using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int upperLimit = Convert.ToInt32(txtUpperBound.Text) + 1;
            long runningSum = 0;
            //will hold all numbers up to the upperlimit
            bool[] numberList = new bool[upperLimit];
            //populate the list
            for (int i = 2; i < upperLimit; i++)
                numberList[i] = true;
            //add 2 to the numbers list as prime
            int removeNumber = 2;
            //if i is prime, numberList[i] == true
            while (removeNumber < upperLimit - 1)
            {
                //remove numbers that are multiples of remove number, starting with 2
                for (int i = removeNumber * 2; i < upperLimit; i = i + removeNumber)
                {
                    numberList[i] = false;
                }
                do
                {
                    //check if we've reached upperlimit
                    if(removeNumber != upperLimit - 1)
                        removeNumber++;//incrememnts remove limit till we find one that isn't a muliple of a number already checked
                    else
                        break;
                }
                while (numberList[removeNumber] == false);
            }
            //add all the numbers from the constucted array up
            for (int i = 0; i < upperLimit; i++)
                if (numberList[i] == true)
                    runningSum += i;
            lblAnswer.Text = runningSum.ToString();
        }

        static bool isPrime(int testNumber)
        {
            if (testNumber % 2 == 0)
                return false;
            for (int i = 3; i <= Math.Sqrt(testNumber); i += 2)
            {
                if (testNumber % i == 0)
                    return false;
            }
            return true;
        }
    }
}
