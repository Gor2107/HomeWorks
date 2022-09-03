using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson2_0_Additional_Task_SortedList
{
    internal class Program
    {
        static void Main()
        {
            SortedList<string, string> temp = new SortedList<string, string>()
            {
                {"D","D_yan" },
                {"A","A_yan" },
                {"C","C_yan" },
                {"B","B_yan" },
            };
            foreach (var item in temp)
            {
                Console.WriteLine(item.Key + "_" + item.Value);
            }

            var vvv= from x in temp orderby x.Key descending select x;
            Console.WriteLine(new string('#',20));
            foreach (var item in vvv)
            {
                Console.WriteLine(item.Key + "_" + item.Value);
            }
            Console.WriteLine(new string('#', 20));
            SortedList temp1 = new SortedList(new DescendngComparer())
            {
                {"D","D_yan" },
                {"A","A_yan" },
                {"C","C_yan" },
                {"B","B_yan" },
            };
            foreach (DictionaryEntry item in temp1)
            {
                Console.WriteLine(item.Key + "_" + item.Value);
            }
            Console.ReadKey();
        }
    }
    class DescendngComparer : IComparer
    {
        readonly CaseInsensitiveComparer comparer=new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comparer.Compare(y,x);
        }
    }
}
