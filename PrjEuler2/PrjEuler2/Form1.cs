using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int runningSum = 0, currentFib = 1, nextFib = 2;
            while(Convert.ToInt32(txtMax.Text) >= currentFib)
            {
                if (currentFib % 2 == 0)
                    runningSum += currentFib;
                int tempValueHolder = nextFib;
                nextFib = nextFib + currentFib;
                currentFib = tempValueHolder;
            }
            //could also just add up every third fibonacci number, they are all the even ones
            lblAnswer.Text = runningSum.ToString();
         }
    }
}
