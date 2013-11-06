using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler17
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLetters = 0;
            for (int i = 1; i <= 1000; i++)
            {
                totalLetters += lettersInANumber(i);
            }
            //we need to subtract 27 for the and that isn't included in eg 100, 200, 300
            totalLetters -= 27;
            Console.WriteLine("There are {0} letters in all the spelled out numbers from 1 to 1000", totalLetters);
        }

        static int lettersInANumber(int inputNumber)
        {
            if (inputNumber < 20)
            {
                switch (inputNumber)
                {
                    case 1:
                    case 2:
                    case 10:
                    case 6:
                        return 3;
                    case 3:
                    case 7:
                    case 8:
                        return 5;
                    case 4:
                    case 5:
                    case 9:
                        return 4;
                    case 11:
                    case 12:
                        return 6;
                    case 15:
                    case 16:
                        return 7;
                    case 13:
                    case 14:
                    case 18:
                    case 19:
                        return 8;
                    case 17:
                        return 9;
                    case 0:
                        return 0;

                }
            }
            if (inputNumber > 19 && inputNumber < 100)
            {
                int singlesDigit = inputNumber % 10;
                int tensDigit = inputNumber - singlesDigit;
                switch (tensDigit)
                {
                    case 40:
                    case 50:
                    case 60:
                        return 5 + lettersInANumber(singlesDigit);
                    case 20:
                    case 30:
                    case 80:
                    case 90:
                        return 6 + lettersInANumber(singlesDigit);
                    case 70:
                        return 7 + lettersInANumber(singlesDigit);
                    case 0:
                        return 0;
                }
            }
            if (inputNumber > 99 && inputNumber != 1000)
            {
                int tensDigit = (inputNumber % 100);
                int hunderedsDigit = (inputNumber - tensDigit) / 100;
                return 10 + lettersInANumber(hunderedsDigit) + lettersInANumber(tensDigit);
            }
            //1000
            return 11;
        }
    }
}
