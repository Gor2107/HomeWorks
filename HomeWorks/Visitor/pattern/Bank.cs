using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.pattern
{
    internal class Bank
    {
        public List<IAccount> accounts { get; set; }=new List<IAccount>();
        public void Add(IAccount account) => accounts.Add(account);
        public void Remove(IAccount account) => accounts.Remove(account);

        public void Accept(IVisitor visitor)
        {
            foreach (var account in accounts)
            {
                account.Accept(visitor);
            }
        }
    }
}
