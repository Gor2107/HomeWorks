using ExchangeRates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
//using System.Text.Json.Serialization;

namespace JsonSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
           string fileName= @"C:\Users\User\Desktop\C#\ACA C# Courses\Programs\Homeworks\HomeWorks\JsonSerialize\Rates.json";
            string jsonString = File.ReadAllText(fileName);
            ExchangeRate tmp = JsonSerializer.Deserialize<ExchangeRate>(jsonString);
          //  string regexPattern = @"base";
          //  Match next = Regex.Match(jsonString,regexPattern);
          //tmp.Base = jsonString.Substring(next.Index+7,3);

            foreach (var item in tmp.rates)
            {
                Console.WriteLine(item.Key + "   " + Math.Round(item.Value, 3));
            }

            Console.WriteLine(">" + tmp.Base + "<");
        }
    }
}
