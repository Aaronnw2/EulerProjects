using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string searchString = txtThousandDigitNumber.Text;
            int highestProduct = 0;
            string highestProdoctstring = "";
            //setup the first string to check
            int firstNumber = Convert.ToInt32(searchString.Substring(0, 1));
            int secondNumber = Convert.ToInt32(searchString.Substring(1, 1));
            int thirdNumber = Convert.ToInt32(searchString.Substring(2, 1));
            int forthNumber = Convert.ToInt32(searchString.Substring(3, 1));
            int fifthNumber = Convert.ToInt32(searchString.Substring(4, 1));
            //check all consecutive digits
            for (int i = 4; i < searchString.Length; i++)
            {
                //check ifthis one is the largest product
                if(firstNumber * secondNumber * thirdNumber * forthNumber * fifthNumber > highestProduct)
                {
                    highestProduct = firstNumber * secondNumber * thirdNumber * forthNumber * fifthNumber;
                    highestProdoctstring = firstNumber.ToString() + secondNumber.ToString() + thirdNumber.ToString() + forthNumber.ToString() + fifthNumber.ToString();
                }
                //setup the next 5 digits to test
                firstNumber = secondNumber;
                secondNumber = thirdNumber; 
                thirdNumber = forthNumber;
                forthNumber = fifthNumber;
                fifthNumber = Convert.ToInt32(searchString.Substring(i, 1));
            }
            lblAnswer.Text = highestProduct.ToString() + " digits: " + highestProdoctstring;
        }
    }
}
