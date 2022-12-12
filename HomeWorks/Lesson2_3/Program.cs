using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2_3
{
    internal class Program
    {
        TaskFactory<int> task;
        static void Main(string[] args)
        {
            ThreadWorker<int> worker = new ThreadWorker<int>(Calculate);
            worker.Start(100);
            while (!worker.IsCompleted)
            {
                Thread.Sleep(50);
                Console.Write("!");
            }
            Console.WriteLine(" Result: {0}", worker.Result);
        }
        public static int Calculate(object sleepTimer)
        {
            int counter = 0;
            int length = (int)sleepTimer;
            for (int i = 0; i < length; i++)
            {
                Thread.Sleep(length);
                counter += i;
            }
            return counter;
        }
    }
}
