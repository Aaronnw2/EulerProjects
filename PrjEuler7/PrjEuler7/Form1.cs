using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n =  Convert.ToInt32(txtn.Text);
            //start at pthe prime number 3
            int checkNumber = 3;
            List<int> primes = new List<int>();
            //add two  to the list as we are starting at 3
            primes.Add(2);
            while (primes.Count < n)
            {
                if (isPrime(checkNumber) == true)
                {
                    primes.Add(checkNumber);
                }
                //only need to check odd numbers
                checkNumber += 2;
            }
            
            lblAnswer.Text = primes.Max().ToString();
        }

        public bool isPrime(int testNumber)
        {
            //check if its divisible by 2
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
