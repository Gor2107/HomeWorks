using System;
using System.Threading;

namespace Lesson2_2
{
    internal class Program
    {
        static void Main()
        {
            var worker = new ThreadWorker(WriteChar);
            worker.Start('*');
            worker.Start('-');
            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(23);
                Console.Write("%");
            }
            worker.Wait();
            Console.WriteLine("Main fineshed");
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

