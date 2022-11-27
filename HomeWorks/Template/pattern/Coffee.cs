using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.pattern
{
    internal abstract class Coffee
    {
        public void MakeCoffe()
        {
            BoilWater();
            Pour();
            AddSugar();
            AddCoffer();
            Stir();
            Console.WriteLine($"your {this.GetType().Name} is ready !!!");
        }
        protected virtual void BoilWater() => Console.WriteLine("Boiled water");
        protected virtual void Pour() => Console.WriteLine("poured water into cup");
        protected abstract void AddSugar();
        protected abstract void AddCoffer();
        protected virtual void Stir() => Console.WriteLine("stired the coffee");
    }

    class CoffeWithMilk : Coffee
    {
        protected override void AddCoffer()=>Console.WriteLine("added one teaspoon of coffee and 50 mg milk");
        protected override void AddSugar()=>Console.WriteLine("added one teaspoon of sugar");
    }
    class Essspresso : Coffee
    {
        protected override void AddCoffer() => Console.WriteLine("added two teaspoon of coffee");
        protected override void AddSugar() {}
    }
}
