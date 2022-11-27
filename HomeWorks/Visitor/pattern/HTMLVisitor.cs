using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.pattern
{
    internal class HTMLVisitor : IVisitor
    {
        public string VisitPersonAccount(Person person)
        {
            string result = $"<Table><tr><td>Name: {person.Name}</td></tr>\n";
             result += $"<tr><td>Surname: {person.Surname}</td></tr>\n";
             result += $"<tr><td>Account: {person.Account}</td></tr></table>\n";
            return result;
        }

        public string VisitCompanyAccount(Company company)
        {
            string result = $"<Table><tr><td>Name: {company.Description}</td></tr>\n";
            result += $"<tr><td>Account: {company.Account}</td></tr></table>\n";
            return result;
        }
    }
}
