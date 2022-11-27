using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.pattern
{
    public class ConcreteBuilder : Builder
    {
        public override Product Product { get; set; }

        public override Builder BuldPartA()
        {
            Product.Add("PartA is builded");
            return this;
        }

        public override Builder BuldPartB()
        {
            Product.Add("PartB is Builded");
            return this;
        }

        public override Builder BuldPartC()
        {
            Product.Add("PartC is builded");
            return this;
        }
        public override Product GetResult()
        {
            return Product;
        }
    }
}
