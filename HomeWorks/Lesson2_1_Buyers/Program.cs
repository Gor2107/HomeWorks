using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Lesson2_1_Buyers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Sales = new Dictionary<string, List<string>>();
            Sales.Add("Gor Melkumyan", new List<string>() {"Milk","Bred","Butter","Meat"});
            Sales.Add("John Smith", new List<string>() {"Meat"});
            Sales.Add("Morgan Friman", new List<string>() { "Meat", "Cola" });
            Sales.Add("Kim Kardashian",new List<string>(){ "Meat", "Wheat","Butter"});
            

           

            Console.WriteLine("#######   Gor Melkumyan's products   using LINQ #########");
            foreach (var item in Sales.Where(prop=>prop.Key == "Gor Melkumyan"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("#######   Gor Melkumyan's products   using Key #########");
            foreach (var item in Sales["Gor Melkumyan"])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("#######   Morgan Friman's products   #########");
            foreach (var item in Sales["Morgan Friman"])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("#######   Customers who bought meat   #########");
            foreach (var item in Sales)
            {
                if (item.Value.Contains("Meat"))
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public override bool Equals(object obj)
        {
            return FullName.Equals((obj as Customer).FullName);
        }
        public override int GetHashCode()
        {
            return this.FullName.GetHashCode();
        }
    }
}
