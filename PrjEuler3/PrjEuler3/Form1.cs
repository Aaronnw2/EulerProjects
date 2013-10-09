using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(txtNumber.Text);
            List<long> factorList = new List<long>();
            //only check up to sqrt(number)
            for (int i = 2; i < Math.Sqrt(number); i++ )
            {
                if (number % i == 0)
                {
                    //i is a factor
                    factorList.Add(i);
                    factorList.Add((number / i));//if i is a factor => i*a = number f.s. a in N, so a is also a factor
                }
            }
            factorList.Sort();
            bool primeFound = false;
            while(primeFound == false)//check factors for primes
            {
                if(isPrime(factorList.Max()) == true)//start at the top
                    primeFound = true;//if it's prime, we have found our answer
                else
                    factorList.Remove(factorList.Max());//if not, discard it from the list
            }
            lblAnswer.Text = factorList.Max().ToString();
        }

        //checks if the number is prime
        public bool isPrime(long testNumber)
        {
            if( testNumber % 2 == 0)
                return false;
            //again, we only need to check sqrt(testNumber), like before. if the number has any factors, there will be a coorisponding one
            for (int i = 3; i * i < testNumber; i = i + 2)
                if (testNumber % i == 0)
                    return false;
            return true;//if it made it through the previous loop, then it has no factors other than 1, and is prime
        }
    }
}
