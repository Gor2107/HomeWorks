using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Wrapper.Pattern
{
    internal class CamelToTransportAdapter : Camel, ITransport
    {
        public void Drive()
        {
            Move();
        }
    }
}
