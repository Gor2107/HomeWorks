using System;
using System.Threading;

namespace Lesson2_2
{
    internal class Program
    {
        static void Main()
        {
            ThreadWorker worker = new(WriteChar);
            ThreadWorker worker1 = new(WriteChar);
            worker.Start('*');
            worker1.Start('!');
            worker.Wait();
            worker1.Wait();
            Console.ReadLine();
        }

        public static void WriteChar(object symbol)
        {
            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(100);
                Console.Write((char)symbol);
            }
        }
    }
}

