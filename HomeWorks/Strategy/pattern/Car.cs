using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.pattern
{
    internal class Car
    {
        public IMoveable Moveable { get; set; }
        readonly string model ;
        public Car(string model, IMoveable moveable)
        {
            this.Moveable = moveable;
           this. model =model;
        }
        public void StartMoving()
        {
            Console.Write($"{model} is ");
            Moveable.Move();
        }
    }
}
