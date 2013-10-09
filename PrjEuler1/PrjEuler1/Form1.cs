using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numberOne = Convert.ToInt32(txtNumberOne.Text), numberTwo = Convert.ToInt32(txtNumberTwo.Text), runningSum = 0;
            for (int i = 1; i <= Convert.ToInt32(txtUpTo.Text); i++)
            {
                if (i % numberOne == 0 || i % numberTwo == 0)
                    runningSum += i;
            }
            lblAnswer.Text = runningSum.ToString();
        }
    }
}
