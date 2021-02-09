/*  Write a function that prints the next 20 leap years (նահանջտարի) starting from 2021   */

using System;

namespace LeapYears
{
    class Program
    {
        public static void PrintLeapYears()
        {
            int count = 0;
            int i = 1;
            int startYear = 2021;
            while (count < 20)
            {
                if (DateTime.DaysInMonth(startYear + i, 2) == 29)
                {
                    Console.WriteLine(startYear + i);
                    count += 1;
                }
                if (count == 0)
                {
                    i++;
                }
                else
                {
                    i += 4;
                }
            }
        }
        static void Main()
        {
            PrintLeapYears();
        }
    }
}
