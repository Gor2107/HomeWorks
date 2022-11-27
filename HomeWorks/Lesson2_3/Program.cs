using System;
using System.Threading;

namespace Lesson2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadWorker<int> worker = new ThreadWorker<int>(Calculate);
            worker.Start(203);
            while (!worker.IsCompleted)
            {
                Thread.Sleep(23);
                Console.Write("!");
            }
            Console.WriteLine(worker.Result);
        }
        public static int Calculate(object sleepTimer)
        {
            int counter = 0;
            int length = (int)sleepTimer;
            for (int i = 0; i < length; i++)
            {
                Console.Write(".");
                Thread.Sleep(length);
                counter += i;
            }
            return counter;
        }
    }
}
