using System;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ThreadPool.QueueUserWorkItem(new WaitCallback(WriteChar),'*');
             ThreadPool.QueueUserWorkItem(new WaitCallback(WriteChar),'!');
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
