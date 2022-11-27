using Adapter.Wrapper.Pattern;
using System;

namespace Adapter.Wrapper.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITransport camelAdapter = new CamelToTransportAdapter();
            camelAdapter.Drive();
            ITransport car = new Car();
            car.Drive();
            var camel = camelAdapter as Camel;
            camel.Move();

        }
    }
}
