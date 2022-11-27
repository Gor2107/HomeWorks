using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.pattern
{
    public abstract class Builder
    {
        public abstract Product Product { get; set; }
        public Builder()
        {
            Product = new Product();
        }
        public abstract Builder BuldPartA();
        public abstract Builder BuldPartB();
        public abstract Builder BuldPartC();
        public abstract Product GetResult();
    }
}
