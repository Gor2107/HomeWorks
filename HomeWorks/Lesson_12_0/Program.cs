using System;
using System.IO;
using System.Threading;

namespace Lesson_12_0
{
    internal class Program
    {

        static Semaphore semaphore = new Semaphore(2, 6, "global::GUID");
        //static Mutex mutex = new Mutex();
        static void Main()
        {
            Console.ReadKey();
            Console.WriteLine("MAIN START");
            int length = 8;
            Thread[] threads = new Thread[length];
            using FileStream stream = new FileStream(
                                                        "Semaphore.txt",
                                                        FileMode.OpenOrCreate,
                                                        FileAccess.ReadWrite
                                                    );
            using StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i < threads.Length; i++)
            {

                threads[i] = new Thread(Method);
                threads[i].Start((writer, i + 1));
                threads[i].IsBackground = false;
                Thread.Sleep(100);
            }
            //mutex.WaitOne();
            //semaphore.Release(4);
            Console.WriteLine("MAIN END");
            //mutex.ReleaseMutex();
            Console.ReadKey();
        }
        static void Method(object data)
        {
            (StreamWriter, int) b = ((StreamWriter, int))data;
            semaphore.WaitOne();
            //mutex.WaitOne();
            b.Item1.WriteLine($"Thread {b.Item2} started");
            Console.WriteLine($"Thread {b.Item2} started");
            Thread.Sleep(2000);
            b.Item1.WriteLine($"Thread {b.Item2} ended");
            Console.WriteLine($"Thread {b.Item2} ended");
            //mutex.ReleaseMutex();
            semaphore.Release();
        }

    }
}
