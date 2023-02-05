namespace Lesson3_3
{
    internal class Program
    {
        static void Main()
        {
            var delayTaskScheduler = new DelayTaskScheduler();
            var task = new Task(() => {
                Console.WriteLine();
                Console.WriteLine($"Task N:{Task.CurrentId} run in thread N:{Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Is From  threadpool {Thread.CurrentThread.IsThreadPoolThread}");
            });
            task.Start(delayTaskScheduler);
            while (!task.IsCompleted)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}