/*
 1. Write a program that asks the user for a number n and gives them ​the possibility tochoose​ between computing
 the sum and computing the product of numbers from 1 to inincluded.
 For example:
Please enter any integer: 
5
--for computing sum enter 1
--for computing multiplication enter 2
2
The multiplication result is 120 */

using System;

namespace SumOrMultiple
{
    class Program
    {
        public static int Sum(int N)
        {
            if (N == 0)
            {
                return N;
            }
            return N + Sum(N - 1);
        }
        public static int Factorial(int N)
        {
            if (N == 0)
            {
                return N;
            }
            if (N == 1)
            {
                return N;
            }
            return N * Factorial(N - 1);

        }

        static void Main()
        {

            Console.WriteLine("Please enter any integer:");
            bool isParsed = int.TryParse(Console.ReadLine(), out int n);

            if (!isParsed || n < 0)
            {
                Console.WriteLine("You entered an incorrect number");
                return;
            }


            Console.WriteLine("--for computing sum enter 1");
            Console.WriteLine("--for computing multiplication enter 2");

            isParsed = int.TryParse(Console.ReadLine(), out int Action);

            if (isParsed)
            {
                if (Action == 1)
                {
                    Console.WriteLine(Sum(n));
                }
                else if (Action == 2)
                {
                    Console.WriteLine(Factorial(n));
                }
                else
                {
                    Console.WriteLine($"You must press '2' or '1'");
                }

            }
        }
    }
}
