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
            long[][] input = new long[100][];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    input[i][j] = Convert.ToInt64(textInput.Substring(i*50,1));
                }
            }
        }
    }
}
