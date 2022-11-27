using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactoryProduct
{
    internal class ConcreteProductB : IAbstractProductB
    {
        public void Interact(IAbstractProductA productA)
        {
            Console.WriteLine("ineract " + GetType().Name + " with " + productA.GetType().Name);
        }
    }
}
