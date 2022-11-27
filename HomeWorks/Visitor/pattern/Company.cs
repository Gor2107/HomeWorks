using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.pattern
{
    internal class Company :IAccount
    {
        public string Description = "\"Coca Cola\" LLC";
        public long Account = 22000_00014_12341;
        public  void Accept(IVisitor visitor)
        {
            Console.WriteLine(   visitor.VisitCompanyAccount(this));
        }
    }
}
