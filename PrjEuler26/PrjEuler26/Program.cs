﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler26
{
    class Program
    {
        static void Main(string[] args)
        {
            //a number 1/p where p is prime
            //multiplicitive order 10 mod p where p has all factors of 2 and 5 taken out
            int[] multiplicativeOrder = new int[1000];
            for (int i = 1; i <= 1000; i++)
            {
                int reducedNumber = i;
                while (reducedNumber % 2 == 0)
                    reducedNumber = reducedNumber / 2;
                while (reducedNumber % 5 == 0)
                    reducedNumber = reducedNumber / 5;
                for (int power = 1; power <= 1000; power++)
                {
                    if (Math.Pow(10, power) % reducedNumber == 1)
                    {
                        multiplicativeOrder[i] = power;
                        break;
                    }
                }
            }
            int highestOrder = 0;
            for (int i = 0; i < 1000; i++)
                if (multiplicativeOrder[i] > highestOrder)
                    highestOrder = i;
            Console.WriteLine("Highest order is 1/{0}", highestOrder);
        }
    }
}
