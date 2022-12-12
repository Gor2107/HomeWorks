using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2_2
{

    class ThreadWorker
    {
        private Action<object> _action;
        public bool IsCompleted { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsFaulted { get; set; }
        public Exception Exception { get; set; }
        public ThreadWorker(Action<object> action) => _action = action ?? throw new ArgumentException(nameof(action));

        public void Start(object state)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadExecutor), state);
        }

        private void ThreadExecutor(object state)
        {
            try
            {
                _action.Invoke(state);
                IsSuccess = true;
            }
            catch (Exception ex)
            {
                IsFaulted = true;
                IsSuccess = false;
                Exception = ex;
            }
            finally
            {
                IsCompleted = true;
            }
        }

        public void Wait()
        {
            while (!IsCompleted) Thread.Sleep(100);
            if (Exception != null) throw Exception;
        }
    }
}
