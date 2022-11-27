using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.pattern
{
    public class Product
    {
        public List<string>? parts;
        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            if (parts != null) this.parts.Add(part);
        }
    }
}
