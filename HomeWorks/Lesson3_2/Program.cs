



using System.Security.Cryptography.X509Certificates;

namespace Lesson3_2
{
    internal class Program
    {
             static int i=0;
        static void Main(string[] args)
        {
            var stackTaskScheduler = new StackTaskScheduler();
            Task[] tasks = new Task[5];
            for (; i < tasks.Length; Interlocked.Increment(ref i))
            {
                tasks[i] = new Task(() =>
                {
                    Console.WriteLine($"task N:{Task.CurrentId} run in thread N:{Thread.CurrentThread.ManagedThreadId}");
                    
                });
                tasks[i].Start(stackTaskScheduler);
            }
            Task.WaitAll(tasks);
        }
    }
}