/*  Write a function that takes a list of strings and prints them, one per line, in arectangular box. */
using System;

namespace PrintWordsInRectangle
{
    class Program
    {
        public static void PrintInRectangularBox(string expression)
        {
            int maxLength = default;
            string[] Words = expression.Split(' ');

            for (int j = 0; j < Words.Length; j++)
            {
                if (maxLength < Words[j].Length)
                {
                    maxLength = Words[j].Length;
                }
            }

            Console.WriteLine(new string('*', 5 + maxLength));
            for (int i = 0; i < Words.Length; i++)
            {
                int k = (maxLength - Words[i].Length);
                string spaces = new string(' ', k);
                string L = $"*  {Words[i]}{spaces} *";
                Console.WriteLine(L);
            }
            Console.WriteLine(new string('*', 5 + maxLength));
        }
        static void Main()
        {

            Console.WriteLine("Write your expression:");
            string expression = Console.ReadLine();

            PrintInRectangularBox(expression);

        }
    }
}
