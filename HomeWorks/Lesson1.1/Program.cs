using System;
using System.Collections;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Collections.Specialized;

namespace Lesson1_1_Months
{
    class Program
    {
        #region Additional task: GetSquareofOddNumbers
        public static IEnumerable<int> GetSquareofOddNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length && numbers[i] % 2 != 0; i++)
               yield return numbers[i] * numbers[i];
        }
        #endregion GetSquareofOddNumbers
        public static void Main()
        {

            Months months = new Months();
            foreach (var item in months)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 10));
            foreach (var item in Months.GetMonthsbyDays(28))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));
            Console.WriteLine(Months.GetMonthByNumber(12));
        }
    }
}

