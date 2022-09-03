using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using static System.Console;

namespace Leeson4_1
{
    internal class Program
    {
        static string GetLogin()
        {
            Write("Write your username: ");
            string result = ReadLine();
            while (!TextChecker(result, @"^[a-zA-Z]+$"))
            {
                WriteLine("Login mustn't contain any number, try again.\nWrite your username again: ");
                result = ReadLine();
            };
            Console.WriteLine("login is successfull");
            return result;
        }
        static string GetPassword()
        {
            Write("Write your password: ");
            string result = ReadLine();
            while (!TextChecker(result, @"^[A-Za-z0-9\S*]+$"))
            {
                WriteLine("Password must contain at least one number, try again.\nWrite your password again: ");
                result = ReadLine();
            };
            Console.WriteLine("password is successfull");
            return result;
        }
        static bool TextChecker(string text, string pattern) => Regex.Match(text, pattern).Success;
        static void Main()
        {
            GetLogin();
            GetPassword();
            Console.ReadKey();
        }
    }
}
