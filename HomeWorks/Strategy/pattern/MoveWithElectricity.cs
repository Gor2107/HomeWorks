using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.pattern
{
    internal class MoveWithElectricity : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("movig using electricty");
        }
    }
}
