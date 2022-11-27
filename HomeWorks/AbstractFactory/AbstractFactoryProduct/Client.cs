using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractFactoryProduct;

namespace AbstractFactory
{
    internal class Client
    {
        IAbstractProductA A;
        IAbstractProductB B;
        public Client(IAbstractFactory factory)
        {
            A = factory.CreateProductA();
            B = factory.CreateProductB();
        }
        public void Run()
        {
            B.Interact(A);
        }
    }
}
