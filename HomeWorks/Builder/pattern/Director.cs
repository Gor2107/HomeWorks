using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder.pattern
{
    public class Director
    {
        public Builder Builder { get; set; }
        public Director(Builder builder)
        {
            this.Builder = builder;
        }
        public void Construct()
        {
            Builder.BuldPartA()
                       .BuldPartB()
                       .BuldPartC();
        }

    }
}
