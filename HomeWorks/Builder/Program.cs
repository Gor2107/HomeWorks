namespace Builder.pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            var product = builder.GetResult();
            foreach (var item in product.parts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Cola example
            builder = new CocaBuilder();
            director = new Director(builder);
            director.Construct();
            product = builder.GetResult();
            foreach (var item in product.parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}