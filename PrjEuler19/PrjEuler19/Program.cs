using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjEuler19
{
    class Program
    {
        static void Main(string[] args)
        {
            int date = 1, dayOfTheWeek = 1, sundayTheFirsts = 0;
            for (int year = 1900; year < 2001; year++)
            {
                for (int month = 1; month < 13; month++)
                {
                    date = 1;
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            for (int k = 1; k < 32; k++)
                            {
                                if (dayOfTheWeek == 7)
                                {
                                    dayOfTheWeek = 1;
                                }
                                else
                                {
                                    dayOfTheWeek++;
                                }
                                if (date == 1 && dayOfTheWeek == 1 && year > 1900)
                                    sundayTheFirsts++;
                                date++;
                            }
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            for (int k = 1; k < 31; k++)
                            {
                                if (dayOfTheWeek == 7)
                                {
                                    dayOfTheWeek = 1;
                                }
                                else
                                {
                                    dayOfTheWeek++;
                                }
                                date++;
                                if (date == 1 && dayOfTheWeek == 1 && year > 1900)
                                    sundayTheFirsts++;
                            }
                            break;
                        case 2:
                            int daysInFeb;
                            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                                daysInFeb = 29;
                            else
                                daysInFeb = 28;
                            for (int k = 1; k <= daysInFeb; k++)
                            {
                                if (dayOfTheWeek == 7)
                                {
                                    dayOfTheWeek = 1;
                                }
                                else
                                {
                                    dayOfTheWeek++;
                                }
                                date++;
                                if (date == 1 && dayOfTheWeek == 1 && year > 1900)
                                    sundayTheFirsts++;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine(sundayTheFirsts);
        }
    }
}
