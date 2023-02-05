using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_3
{
    internal class DelayTaskScheduler : TaskScheduler
    {

        protected override IEnumerable<Task>? GetScheduledTasks() => Enumerable.Empty<Task>();

        protected override void QueueTask(Task task)
        {
            var timer =new Timer((_)=> TryExecuteTask(task),null, 2000,1);
        }

        protected override bool TryExecuteTaskInline(Task _, bool taskWasPreviouslyQueued)
        => false;
    }
}
