using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.pattern
{
    internal interface IVisitor
    {
        string VisitPersonAccount(Person person);
        string VisitCompanyAccount(Company company);
    }
}
