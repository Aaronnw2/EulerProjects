using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler11
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
            string fullInput = txtInput.Text;
            int[,] inputArray = new int[20,20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    inputArray[i,j] = Convert.ToInt32(fullInput.Substring(59 * i + 2 * i + 3 * j, 2));
                }
            }
            int highestProduct = 0;
            string highestNumbers = "";
            //check all 4-pules starting with any number in every direction (if a proper 4-pule exists
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    //check the right
                    if (j < 17)//a 4-pule to the right exists
                    {
                        if (inputArray[i,j] * inputArray[i,j + 1] * inputArray[i,j + 2] * inputArray[i,j + 3] > highestProduct)
                        {
                            highestProduct = inputArray[i,j] * inputArray[i,j + 1] * inputArray[i,j + 2] * inputArray[i,j + 3];
                            highestNumbers = string.Format("Numbers (right): {0}, {1}, {2}, {3}\nAt: {4},{5}", inputArray[i,j] , inputArray[i,j + 1] , inputArray[i,j + 2] , inputArray[i,j + 3] , i, j);
                        }
                    }
                    //check down
                    if (i < 17)
                    {
                        if (inputArray[i, j] * inputArray[i + 1, j] * inputArray[i + 2, j] * inputArray[i + 3, j] > highestProduct)
                        {
                            highestProduct = inputArray[i, j] * inputArray[i + 1, j] * inputArray[i + 2, j] * inputArray[i + 3, j];
                            highestNumbers = string.Format("Numbers (down):\n{0}, {1}, {3}\nAt: {4},{5}", inputArray[i, j] , inputArray[i + 1, j] , inputArray[i + 2, j] , inputArray[i + 3, j], i,j);
                        }
                    }
                    //check diagonaly right
                    if (i < 17 && j < 17)
                    {
                        if (inputArray[i, j] * inputArray[i + 1, j + 1] * inputArray[i + 2, j + 2] * inputArray[i + 3, j + 3] > highestProduct)
                        {
                            highestProduct = inputArray[i, j] * inputArray[i + 1, j + 1] * inputArray[i + 2, j + 2] * inputArray[i + 3, j + 3];
                            highestNumbers = string.Format("Numbers (dia right):\n{0}, {1}, {2}, {3}\nAt: {4},{5}", inputArray[i, j] , inputArray[i + 1, j + 1] , inputArray[i + 2, j + 2] , inputArray[i + 3, j + 3],i,j);
                        }
                    }
                    //check diagonaly left
                    if(i < 17 && j > 2)
                    {
                        if (inputArray[i, j] * inputArray[i + 1, j - 1] * inputArray[i + 2, j - 2] * inputArray[i + 3, j - 3] > highestProduct)
                        {
                            highestProduct = inputArray[i, j] * inputArray[i + 1, j - 1] * inputArray[i + 2, j - 2] * inputArray[i + 3, j - 3];
                            highestNumbers = string.Format("Numbers (dia left):\n{0}, {1}, {2}, {3}\nAt: {4},{5}", inputArray[i, j] , inputArray[i + 1, j - 1] , inputArray[i + 2, j - 2] , inputArray[i + 3, j - 3],i,j);
                        }
                    }
                }
            }
            lblAnswer.Text = "Product: " + highestProduct.ToString() + "\n" + highestNumbers;
        }
    }
}
