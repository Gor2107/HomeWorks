using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.pattern
{
    internal class CocaBuilder : Builder
    {
        public override Product Product { get; set; }
        public override Builder BuldPartA()
        {
            Product.Add("cola lid is ready");
            return this;
        }

        public override Builder BuldPartB()
        {
            Product.Add("Cola water is ready");
            return this;
        }

        public override Builder BuldPartC()
        {
            Product.Add("Cola bottle is ready");
            Product.Add("Coca Cola is ready !!!!!");
            return this;
        }

        public override Product GetResult()
        {
            return Product;
        }
    }
}
