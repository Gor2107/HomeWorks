using System;

namespace Homeworks2
{



    class Program
    {

        /// <summary>
        /// Performs basic string compression using the counts of repeatedcharacters. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CompressString(string text)
        {
            string result = string.Empty;

            for (int i = 0; i < text.Length;)
            {
                result += text[i];
                int count = 1;
                for (int j = i + 1; j < text.Length && text[i] == text[j]; j++)
                {
                    count++;
                }
                result += count;
                i += count;
            }

            return result;
        }


        /// <summary>
        /// Replaces all spaces in a string with ‘%20’ 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReplaceSpaces(string text)
        {
            string result = string.Empty;
            string[] splittedtext = text.Split(' ');
            for (int i = 0; i < splittedtext.Length; i++)
            {
                if (i == splittedtext.Length - 1)
                {
                    result += splittedtext[i];
                    break;
                }
                result += splittedtext[i] + "%20";
            }
            return result;
        }

        /// <summary>
        /// Reads any month number in integer and display the number of days for this month. 
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>

        public static string DaysInMonth(int month)
        {
            string days;

            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        days = "This month has 31 days.";
                        break;
                    case 2:
                        days = "This month has 28 days, but in Leap years it has 29 days.";
                        break;
                    default:
                        days = "This month has 30 days.";
                        break;
                }

            }
            else
            {
                days = "You entered an incorrect number.";
            }
            return days;
        }

        /// <summary>
        /// Calculates a student’s grade from an integer and displays on a console
        /// </summary>
        /// <param name="numericValue"></param>
        public static void PrintGrade(int numericValue)
        {
            string grade;

            switch (numericValue)
            {

                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    grade = "F";
                    break;
                case 5:
                    grade = "D";
                    break;
                case 6:
                    grade = "C";
                    break;
                case 7:
                case 8:
                    grade = "B";
                    break;
                case 9:
                    grade = "A";
                    break;
                case 10:
                    grade = "A+";
                    break;

                default:
                    grade = "You entered an incorrect Value";
                    break;
            }

            Console.WriteLine(grade);
        }

        /// <summary>
        /// Sample Calculator 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string Calculator(int num1, int num2, int action)
        {
            string result;
            switch (action)
            {
                case 1:
                    result = $"The Addition of {num1} and {num2} is: {(num1 + num2)}";
                    break;
                case 2:
                    result = $"The Subtraction of {num1} and {num2} is: {(num1 - num2)}";
                    break;
                case 3:
                    result = $"The Multiplication of {num1} and {num2} is: {(num1 * num2)}";
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = $"The Division of {num1} and {num2} is: {(num1 / (num2 * 1.0))}";
                    }
                    else
                    {
                        result = "Can't divide to 0";
                    }
                    break;
                case 5:
                    result = "!!! You exited from calculator !!!";
                    break;
                default:
                    result = "You entered incorrect action";
                    break;
            }
            return result;
        }
        static void Main()
        {

            //Excercise 1.String Compression

            Console.WriteLine("Excersie 1. \n Write your text to make compression:");
            string text = Console.ReadLine();
            Console.WriteLine(CompressString(text));



            //Excercise 2. URLify

            Console.WriteLine("Excersie 2. \n Write your text to replace spaces:");
            string text1 = Console.ReadLine();
            Console.WriteLine(ReplaceSpaces(text1));



            //Excercise 3. Days in a Month

            Console.WriteLine("Excersie 3. \n Write any month number to know the number of days:");
            bool isParsed = int.TryParse(Console.ReadLine(), out int monthNumber);
            if (isParsed)
            {
                Console.WriteLine(DaysInMonth(monthNumber));
            }
            else
            {
                Console.WriteLine("You entered incorrect number.");
            }



            //Excercise 4. Grade Mapping

            Console.WriteLine("Excersie 4. \n Write Numerical value to calculate a student’s grade:");
            bool isParsed1 = int.TryParse(Console.ReadLine(), out int numericValue);
            if (isParsed1)
            {
                PrintGrade(numericValue);
            }
            else
            {
                Console.WriteLine("You entered an incorrect number.");
            }



            //Excercise 5. Calculator

            int action = 0;
            while (action != 5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the first integer: ");

                Console.ForegroundColor = ConsoleColor.Red;
                bool isparsed2 = int.TryParse(Console.ReadLine(), out int num1);

                if (isparsed2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter the second integer: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    isparsed2 = int.TryParse(Console.ReadLine(), out int num2);

                    if (isparsed2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Choose one of the options:\n1-Addition.\n2-Subtraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n\n\nInput your choice: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        isparsed2 = int.TryParse(Console.ReadLine(), out action);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if (isparsed2)
                        {
                            Console.WriteLine($"{Calculator(num1, num2, action)}\n");
                        }
                        else
                        {
                            Console.WriteLine("action is incorrect\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("second integer is incorrect\n");
                    }

                }
                else
                {
                    Console.WriteLine("first integer is incorrect\n");
                }

            }

        }
    }
}
