using System;

namespace ConsoleApp2Core
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var x = 0;
                dynamic b = x;
             
            }
            catch (ArithmeticException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
