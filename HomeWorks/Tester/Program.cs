using System;
using System.Threading;
using System.Threading.Tasks;


namespace Tester
{
    public class Program
    {
        static void Main()
        {
            //ThreadPool.QueueUserWorkItem(new WaitCallback(WriteChar), '*');
            //ThreadPool.QueueUserWorkItem(new WaitCallback(WriteChar), '!');
            ThreadWorker<int> worker = new(Calculate);
            worker.Start(10);
            while (!worker.IsCompleted)
            {
                Console.Write('#');
                Thread.Sleep(50);
            }
            Console.WriteLine(" Result: {0}",worker.Result);
            Console.ReadLine();
        }
        public static int Calculate(object sleepTime)
        {
            int num = (int)sleepTime;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(num);
                num += i;
            }
            return num;
        }
    }
}
