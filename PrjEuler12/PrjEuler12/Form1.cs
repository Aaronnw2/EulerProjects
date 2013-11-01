using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Set_Class;

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
            //maybe use 2000 = 2^4*5^3 so number of divisors will be (4+1)(3+1) = 20 !!THIS WILL WORK, AND BE MUCH FASTER THAN THE CURRENT METHOD!!
            int inputNumber = Convert.ToInt32(txtInput.Text);
            //the upperbound would be a number that has all prime factors, up to inputNumber / 2
            int[] primeArray = primeArrayConstructor((inputNumber / 2) + 1);
            int testnumber = inputNumber * 2;
            bool solutionFound = false;
            while (solutionFound == false)
            {
                List<int> testNumberDecomp = new List<int>(primeDecomposition(testnumber, primeArray));
                int totalNumberOfFactors = 1, run = 1;
                List<int> factorPowers = new List<int>();
                for (int i = 1; i < testNumberDecomp.Count; i++)
                {
                    if (testNumberDecomp[i] == testNumberDecomp[i - 1])
                    {
                        run++;
                    }
                    else
                    {
                        factorPowers.Add(run);
                        run = 1;
                    }
                }
                //add final factor power
                factorPowers.Add(run);
                for (int j = 0; j < factorPowers.Count; j++)
                {
                        factorPowers[j]++;
                        totalNumberOfFactors *= factorPowers[j];
                }
                if (totalNumberOfFactors == inputNumber)
                {
                    lblAnswer.Text = testnumber.ToString();
                    solutionFound = true;
                }
                else
                    testnumber++;
            }
        }

        //returns the number of unique combos of the prime decomp, which is equivelent to the number of factors a number will have
        //no longer needed
        /*
        public static List<set> numberOfUniqueCombos(List<int> inputList)
        {
            set factorSet = new set(inputList);
            List<set> powerSet = factorSet.PowerSet();
            List<set> returnSet = new List<set>();
            //take out doubles
            for (int i = 0; i < powerSet.Count; i++)
            {
                bool isADouble = false;
                for (int j = i + 1; j < powerSet.Count; j++)
                {

                    if (powerSet[i] == (powerSet[j]))
                    {
                        isADouble = true;
                        break;
                    }
                        this changes powerset.count, and is turning in funny results due to sets being bumped up in index after one is removed
                        powerSet.Remove(powerSet[j]);
                     
                }
                if (isADouble == false)
                    returnSet.Add(powerSet[i]);
            }
            return returnSet;
        }*/

        //returns a list of the unique prime decomposition of (inputNumber)
        public static List<int> primeDecomposition(int inputNumber, int[] primeArray)
        {
            List<int> primeDecomp = new List<int>();
            for (int i = 0; i < primeArray.Length; i++)
            {
                if (inputNumber == 1)
                    break;
                while (inputNumber % primeArray[i] == 0)
                {
                    primeDecomp.Add(primeArray[i]);
                    inputNumber /= primeArray[i];
                }
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
