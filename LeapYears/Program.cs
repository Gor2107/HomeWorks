/*  Write a function that prints the next 20 leap years (նահանջտարի) starting from 2021   */

using System;

namespace LeapYears
{
    class Program
    {
        public static void PrintLeapYears(int startYear, int count)
        {
             
            int i = 1;
            
            while (count > 0)
            {
                if (DateTime.DaysInMonth(startYear + i, 2) == 29)
                {
                    Console.WriteLine(startYear + i);
                    count --;
                }
                if (count == 20)
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
            int startYear = 2021;
            int count = 20;
            PrintLeapYears( startYear, count);
        }
    }
}
