using System;
using Template.pattern;
using Template.pattern2;

namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            Console.WriteLine(new String('-', 25) + "Making coffee" + new String('-', 25));
            Coffee coffee = new CoffeWithMilk();
            coffee.MakeCoffe();
            Console.WriteLine();
            Coffee coffee1 = new Essspresso();
            coffee1.MakeCoffe();

            //Example 2
            Console.WriteLine(new String('-', 27) + "Studiing" + new String('-', 27));
            Education education = new School();
            education.Learn();
            Console.WriteLine();
            Education education1 = new HighUniversity();
            education1.Learn();
        }
    }
}
