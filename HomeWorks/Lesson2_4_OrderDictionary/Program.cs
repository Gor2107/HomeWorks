using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4_OrderDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary collection = new OrderedDictionary(new PersonsComparer());
            collection.Add(new Person(){FullName="And1",ID=1},"@1");
            collection.Add(new Person(){FullName="And1",ID=12},"@2");
            collection.Add(new String(' ', 10),"sdddd");
            collection.Add(new Person(){FullName="And1",ID=14},"@3");
        }
    }
    class Person
    {
        public string FullName { get; set; }
        public int ID { get; set; }
    }
    class PersonsComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            Person temp, temp1;
            if (((temp = x as Person) == null) || ((temp1 = y as Person) == null)) return false;
            else return temp.ID.Equals(temp1.ID);
        }

        public int GetHashCode(object obj)
        {
            if (obj as Person == null)
            {
                return obj.GetHashCode();
            }
            return (obj as Person).ID.GetHashCode();
        }
    }
}
