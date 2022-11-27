using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.pattern
{
    internal class Person : IAccount
    {
        public string Name = "Gor";
        public string Surname="Melkumyan";
        public long Account= 22000_00015_42001;
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine( visitor.VisitPersonAccount(this));
        }
    }
}
