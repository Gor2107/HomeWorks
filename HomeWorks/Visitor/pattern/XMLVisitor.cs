using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.pattern
{
    internal class XMLVisitor:IVisitor
    {
        public string VisitPersonAccount(Person person)
        {
            string result = $"<Person><Name> {person.Name}</Name>\n";
            result += $"<Surname> {person.Surname}</Surname>\n";
            result += $"<Account> {person.Account}</Account></Person>\n";
            return result;
        }

        public string VisitCompanyAccount(Company company)
        {
            string result = $"<Company><Name> {company.Description}</Name>\n";
            result += $"<Account>{company.Account}<Account></Company>\n";
            return result;
        }
    }
}
