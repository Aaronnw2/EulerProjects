using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if a < b < c then a < 1000/3 and b > 1000/2
            for (int a = 1; a < 333; a++)
            {
                for (int b = 2; b < 499; b++)
                {
                    int c = 1000 - (a + b);
                    if (a * a + b * b == c * c)
                        lblAnswer.Text = (a * b * c).ToString() + "\na: " + a.ToString() + " b: " + b.ToString() + " c: " + c.ToString();
                }
            }
        }
    }
}
