using System;
using System.Threading;
using System.Threading.Tasks;


namespace Tester
{
    public class Program
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
    class Singletone
    {
        private static object locker = new object();
        private static volatile Singletone _instance;
        public static Singletone GetInstance()
        {
            lock (locker)
            {
                if (_instance == null)
                {
                    _instance = new Singletone();
                }

                return _instance;
            }
        }
        Singletone()
        {

        }
    }
}
