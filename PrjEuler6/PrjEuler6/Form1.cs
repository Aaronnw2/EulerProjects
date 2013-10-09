using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int nNaturalNumbers = Convert.ToInt32(txtn.Text);
            int answer = 1, sumOfSquares = 0, squareOfSums = 0;
            //square of sums = (n^4 + 2n^2 + n^2) / 4
            squareOfSums = Convert.ToInt32((Math.Pow(nNaturalNumbers, 4) + 2 * Math.Pow(nNaturalNumbers, 3) + Math.Pow(nNaturalNumbers, 2)) / 4);
            //sum of squares = (2n^3 + 3n^2 + n) / 6
            sumOfSquares = Convert.ToInt32((2 * Math.Pow(nNaturalNumbers, 3) + 3 * Math.Pow(nNaturalNumbers, 2) + nNaturalNumbers) / 6);
            answer = squareOfSums - sumOfSquares;
            lblAnswer.Text = answer.ToString();
        }
    }
}
