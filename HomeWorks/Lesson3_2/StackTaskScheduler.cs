using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    internal class StackTaskScheduler : TaskScheduler
    {
        Stack<Task> tasksList=new Stack<Task>();
        protected override IEnumerable<Task>? GetScheduledTasks()
        {
            lock (tasksList)
            {
                return tasksList;
            }
        }

        protected override void QueueTask(Task task)
        {
            tasksList.Push(task);
            NotifyThreadPoolOfPendingWork();
        }

        private void NotifyThreadPoolOfPendingWork()
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                while (true)
                    lock (tasksList)
                        if (tasksList.Count > 0)
                        {
                            var task = tasksList.Pop();
                            if (task != null)
                                TryExecuteTask(task);
                        }
            });
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return TryExecuteTask(task);
        }
    }
}
