/*
 Write a function that encodes a given text by taking the first letter of every word,moving it to the end of the word and 
adding “ey” after it.
For example:
“The quick brown fox jumped over the lazy dog.” 
becomes
“Hetey uickqey rownbey oxfey umpedjey veroey hetey azyley ogdey.”
 */
using System;

namespace TextEncoder
{
    class Program
    {
        public static void EncodeText(string expression)
        {

            string[] Words = expression.Split(' ');

            Words[0] = Words[0].Substring(0, 1).ToLower() + Words[0].Substring(1, Words[0].Length - 1);

            for (int j = 0; j < Words.Length - 1; j++)
            {
                Words[j] = Words[j].Substring(1, Words[j].Length - 1) + Words[j].Substring(0, 1) + "ey";
            }

            Words[0] = Words[0].Substring(0, 1).ToUpper() + Words[0].Substring(1, Words[0].Length - 1);

            for (int i = 0; i < Words.Length; i++)
            {
                if (i == Words.Length - 1)
                {
                    Console.Write($"{Words[i]}");
                }

                else
                {
                    Console.Write($"{Words[i]} ");
                }
            }

        }
        static void Main()
        {

            Console.WriteLine("Write your expression to Encode:");
            string expression = Console.ReadLine();

            EncodeText(expression);

        }
    }
}
