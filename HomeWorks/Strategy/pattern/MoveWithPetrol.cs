using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.pattern
{
    internal class MoveWithPetrol : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("moving using petrol");
        }
    }
}
