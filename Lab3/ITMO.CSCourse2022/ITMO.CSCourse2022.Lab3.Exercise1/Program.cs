using System;
using System.Collections;

namespace ITMO.CSCourse2022.Excercise1
{
    class WhatDay
    {
        enum MonthName
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main()
        {
            Console.Write("Please enter a day number between 1 and 365: ");
            int dayNum = int.Parse(Console.ReadLine());
            int monthNum = 0;
            ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
            MonthName temp = (MonthName)monthNum;
            Console.WriteLine("{0} {1}", temp.ToString(), dayNum);
        }
    }
}
