using System;
using Visitor.pattern;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new ();
            bank.Add(new Person());
            bank.Add(new Company());
            bank.Accept(new XMLVisitor());
        }
    }
}
