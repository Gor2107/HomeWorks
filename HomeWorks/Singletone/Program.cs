using System;
using System.Threading.Tasks;

namespace Singletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new TaskFactory().StartNew(() => Singletone.GetInstance());
            var y = new TaskFactory().StartNew(() => Singletone.GetInstance());
            if (x?.Result != null && y?.Result != null)
            {
                Console.WriteLine(x.Result.GetHashCode());
                Console.WriteLine(y.Result.GetHashCode());
            }
        }
    }
}
