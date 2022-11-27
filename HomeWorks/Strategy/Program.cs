using Strategy.pattern2;

namespace Strategy.pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mercedes = new Car("Mercedes", new MoveWithPetrol());
            mercedes.StartMoving();
            var tesla = new Car("Tesla", new MoveWithElectricity());
            tesla.StartMoving();
            //##############################################
            var collection = new MyCollection(new BubbleSort());
            collection.Sort();
            foreach (var number in collection.Collection)
            {
                System.Console.Write(number+", ");
            }
        }
    }
}
