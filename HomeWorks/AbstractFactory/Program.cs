//using AbstractFactory.AbstractFactoryProduct;
using System;

namespace AbstractFactory.AbstractFactoryProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ConcreteFactory1());
            client.Run();
        }
    }
}
