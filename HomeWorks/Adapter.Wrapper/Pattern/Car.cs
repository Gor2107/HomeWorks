using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Wrapper.Pattern
{
    internal class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
    }
}
