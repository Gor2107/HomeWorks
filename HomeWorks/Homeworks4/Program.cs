using System;
using System.Collections.Generic;
using System.IO;


    class Program
    {
        static void Main()
        {
        string str = "AKALA KALO-KALAKALO";
        str.Replace("A", "");
        Console.WriteLine(str);
        Dictionary<string, string> numbers = new Dictionary<string, string>();
        numbers["1"] = " One"; numbers["2"] = " Two"; numbers["3"] = " Three";
        foreach (KeyValuePair<string, string> pair in numbers) Console.WriteLine("{0}", pair);
    }
    }

