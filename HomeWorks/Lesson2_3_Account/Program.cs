using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> accountinfo = new Dictionary<int, double>()
            {
                { 7654321 , 44.34 },
                { 2200015 , 1.111 },
                { 1234567 , 0.234 },
                { 8912345 , 555.4 },
            };
            foreach (var item in accountinfo)
            {
                Console.WriteLine(item.Key + "_" + item.Value);
            }
            Console.WriteLine(new String('#',30));
            SortedDictionary<int, double> accountinfo1 = new SortedDictionary<int, double>()
            {
                { 2200015 , 1.111 },
                { 1234567 , 0.234 },
                { 8912345 , 555.4 },
                { 7654321 , 44.34 },
            };
            foreach (var item in accountinfo1)
            {
                Console.WriteLine($"AccountNumber` {item.Key} , balance = {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
