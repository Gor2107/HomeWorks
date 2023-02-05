using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2_4
{
    internal class Program
    {
        public static async Task Main()
        {
            Console.WriteLine(Environment.ProcessorCount);
            int[] y = new int[1_000_000_000];
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Parallel.For(0, y.Length, (i) => y[i] = i * i * i * i);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
            watch.Start();
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i * i * i * i;
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();
            watch.Start();
            var q = Task.Run(() =>
            {
                for (int i = 0; i < y.Length/2; i++)
                {
                    y[i] = i * i * i * i;
                }
            });
            var z = Task.Run(() =>
            {
                for (int i = y.Length / 2; i < y.Length ; i++)
                {
                    y[i] = i * i * i * i;
                }
            });
            await Task.WhenAll(q, z);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            var x = TaskScheduler.Current;
            Console.WriteLine(x.MaximumConcurrencyLevel);
            Console.WriteLine(TaskScheduler.Current);
            Console.WriteLine(TaskScheduler.Default);
        }
        public static void MethodAsync()
        {
            Thread.Sleep(2000);
            Console.WriteLine("MethodAsync");
        }
    }
}
