using System;
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
            //multiplicitive order 10 mod p
            int[] multiplicativeOrder = new int[1000];
            for (int i = 1; i <= 1000; i++)
            {
                for (int power = 1; power <= 1000; power++)
                {
                    if (Math.Pow(10, power) % i == 1)
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
