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
        public Action<object> action;
        public bool IsCompleted { get; set; }
        public bool IsFaulted { get; set; }
        public bool IsSuccess { get; set; }
        public Exception Exception { get; set; }
        public ThreadWorker(Action<object> action)
        {
            this.action = action ?? throw new ArgumentNullException(nameof(action));
        }
        public void Start(object state)
        {
            var thread = new Thread(new ThreadStart(
                () =>
                {
                    try
                    {
                        action.Invoke(state);
                        IsSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        IsSuccess = false;
                        IsFaulted = true;
                        Exception = ex;
                        throw;
                    }
                    finally
                    {
                        IsCompleted = true;
                    }
                }
                ));
            thread.Start();
        }

        public void Wait()
        {
            while (IsCompleted == false)
            {
                Thread.Sleep(100);
            }
            if (Exception != null)
            {
                throw Exception;
            }
        }
    }
}
