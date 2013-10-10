using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjEuler12
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
            //the number of factors will be the number of unique combinations of prime factors we can make from the prime decompisition of a number
            //need a lower bound, and an upper bound on the number of primes needed, can maybe trim these down late
            int inputNumber = Convert.ToInt32(txtInput.Text);
            //the upperbound would be a number that has all prime factors, up to inputNumber / 2
            int[] primeArray = primeArrayConstructor(inputNumber / 2);
            int testnumber = Convert.ToInt32(Math.Pow(inputNumber, 2));
            bool solutionFound = false;
            while (solutionFound == false)
            {
                List<int> testNumberDecomp = new List<int>(primeDecomposition(testnumber, primeArray));
                if (numberOfUniqueCombos(testNumberDecomp) >= inputNumber)
                {
                    lblAnswer.Text = testnumber.ToString();
                    solutionFound = true;
                }
                testnumber++;
            }
        }

        //returns the number of unique combos of the prime decomp, which is equivelent to the number of factors a number will have
        public static int numberOfUniqueCombos(List<int> inputList)
        {
            int combinations = 0;
            return combinations;
        }

        //returns a list of the unique prime decomposition of (inputNumber)
        public static List<int> primeDecomposition(int inputNumber, int[] primeArray)
        {
            List<int> primeDecomp = new List<int>();
            for(int i = 0; i < primeArray.Length; i++)
                while (inputNumber % primeArray[i] == 0)
                {
                    primeDecomp.Add(primeArray[i]);
                    inputNumber /= primeArray[i];
                }
            return primeDecomp;
        }

        //returns an array of the first (numberOfPrimes) prime numbers
        public static int[] primeArrayConstructor(int numberOfPrimes)
        {
            int[] primeArray = new int[numberOfPrimes];
            //add 2 to the start of the array
            primeArray[0] = 2;
            int primeCount = 1;
            //start at 3
            int testNumber = 3;
            while (primeCount < numberOfPrimes)
            {
                if (isPrime(testNumber) == true)
                {
                    primeArray[primeCount] = testNumber;
                    primeCount++;
                }
                testNumber++;
            }
            return primeArray;
        }

        public static bool isPrime(int inputNumber)
        {
            if(inputNumber % 2 == 0)
                return false;
            for(int i = 3; i <= Math.Sqrt(inputNumber); i+=2)
            {
                if (inputNumber % i == 0)
                    return false;
            }
            return true;
        }
    }
}
