/*Write a program where the user guesses a secret number. After every guess the program tellsthe user whether 
 their number was too large or too small. At the end print the number of tries ona console. Count only as one try 
 if the user inputs the same number multiple timesconsecutively.*/


using System;
using System.Collections.Generic;
namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            int SecretNumber = new Random().Next(1, 100000);
            int InputNum = 0;
            int attemps = 0;
            List<int> Inputs = new List<int>();

            Console.WriteLine("Type your number from 1 to 100000 to guess the secret number");

            while (InputNum != SecretNumber)
            {
                bool isRepeated = false;
                bool isParsed = int.TryParse(Console.ReadLine(), out InputNum);
                if (!isParsed)
                {
                    Console.WriteLine("You entered not correct number");
                    continue;
                }
                else
                {

                    for (int i = 0; i < Inputs.Count && Inputs.Count != 0; i++)
                    {
                        if (Inputs[i] == InputNum)
                        {
                            isRepeated = true;
                            break;
                        }
                    }

                    if (!isRepeated)
                    {
                        Inputs.Add(InputNum);
                        ++attemps;
                        if (InputNum > SecretNumber)
                        {
                            Console.WriteLine("You entered too large Number, try to enter small number");

                        }
                        else if (InputNum < SecretNumber)
                        {
                            Console.WriteLine("You entered too small Number, try to enter large number");

                        }
                    }
                    else
                    {
                        Console.WriteLine("You has already typed this number, try another number");
                    }

                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"!!!Congratulations!!! \nYou have guessed the secret number --> {SecretNumber}.\n" +
                $"Number of attemps = {attemps}");
            Console.ReadKey(true);
        }

    }
}
